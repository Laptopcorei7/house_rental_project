using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace RentalWeb.Data;

// One-time copy of the WinForms database (HOUSE.mdf) into the new schema.
// Old customers rows each held a person, a booking and a payment status; here they become
// one Customer per email, one Booking per row and one Payment per paid booking.
// Old logins are test accounts and are not copied.
public static class LegacyImport
{
    public static async Task<int> RunAsync(RentalDbContext db, string mdfPath)
    {
        if (!File.Exists(mdfPath))
        {
            Console.Error.WriteLine($"Database file not found: {mdfPath}");
            return 1;
        }

        await db.Database.MigrateAsync();
        if (await db.Houses.AnyAsync() || await db.Bookings.AnyAsync())
        {
            Console.Error.WriteLine("The new database already has houses or bookings. Import refused so nothing is copied twice.");
            return 1;
        }

        var legacy = new SqlConnectionStringBuilder
        {
            DataSource = @"(LocalDB)\MSSQLLocalDB",
            AttachDBFilename = Path.GetFullPath(mdfPath),
            IntegratedSecurity = true,
            ConnectTimeout = 30,
        }.ConnectionString;

        try
        {
            await using var con = new SqlConnection(legacy);
            await con.OpenAsync();

            var houses = await ReadHousesAsync(con);
            db.Houses.AddRange(houses.Values);
            var (customers, bookings) = await ReadBookingsAsync(con, houses);
            db.Customers.AddRange(customers);
            db.Bookings.AddRange(bookings);

            // One SaveChanges call runs in one transaction: either everything is copied or nothing is.
            await db.SaveChangesAsync();
            Console.WriteLine($"Imported {houses.Count} houses, {customers.Count} customers, {bookings.Count} bookings, " +
                              $"{bookings.Sum(b => b.Payments.Count)} payments.");
            return 0;
        }
        catch (Exception ex) when (ex is SqlException or DbUpdateException or InvalidDataException)
        {
            Console.Error.WriteLine($"Import failed, nothing was saved: {ex.GetBaseException().Message}");
            return 1;
        }
    }

    static async Task<Dictionary<string, House>> ReadHousesAsync(SqlConnection con)
    {
        var houses = new Dictionary<string, House>(StringComparer.OrdinalIgnoreCase);
        await using var cmd = new SqlCommand(
            "SELECT house_id, house_name, description, address, number_of_bedrooms, number_of_bathrooms, rent_amount, " +
            "daily_rent, deposit_amount, image_path, date_available, date_update, date_delete, status FROM addHouse", con);
        await using var r = await cmd.ExecuteReaderAsync();
        while (await r.ReadAsync())
        {
            var code = r.GetString(0).Trim();
            houses[code] = new House
            {
                Code = code,
                Name = r.GetString(1),
                Description = r.IsDBNull(2) ? null : r.GetString(2),
                Address = r.GetString(3),
                Bedrooms = r.GetInt32(4),
                Bathrooms = r.GetInt32(5),
                MonthlyRent = r.GetDecimal(6),
                DailyRent = r.GetDecimal(7),
                Deposit = r.GetDecimal(8),
                // Older rows hold a full path; only the file name is kept.
                ImageFileName = Path.GetFileName(r.GetString(9)),
                AvailableFrom = DateOnly.FromDateTime(r.GetDateTime(10)),
                UpdatedOn = r.IsDBNull(11) ? null : DateOnly.FromDateTime(r.GetDateTime(11)),
                DeletedOn = r.IsDBNull(12) ? null : DateOnly.FromDateTime(r.GetDateTime(12)),
                Status = Enum.TryParse<HouseStatus>(r.GetString(13), true, out var s)
                    ? s : throw new InvalidDataException($"House {code} has unknown status '{r.GetString(13)}'."),
            };
        }
        return houses;
    }

    static async Task<(List<Customer>, List<Booking>)> ReadBookingsAsync(SqlConnection con, Dictionary<string, House> houses)
    {
        var customers = new Dictionary<string, Customer>(StringComparer.OrdinalIgnoreCase);
        var bookings = new List<Booking>();
        await using var cmd = new SqlCommand(
            "SELECT id, book_id, full_name, email, contact, gender, house_id, rent_amount, rent_plan, status_payment, status, " +
            "date_start, date_end, date_book FROM customers ORDER BY id", con);
        await using var r = await cmd.ExecuteReaderAsync();
        while (await r.ReadAsync())
        {
            int oldId = r.GetInt32(0);
            if (r.IsDBNull(11) || r.IsDBNull(12) || r.IsDBNull(13))
                throw new InvalidDataException($"Booking row {oldId} is missing its start, end or booking date.");

            var email = r.GetString(3).Trim();
            if (!customers.TryGetValue(email, out var customer))
            {
                customer = new Customer { FullName = r.GetString(2).Trim(), Email = email, Phone = r.GetString(4).Trim(), Gender = r.GetString(5) };
                customers[email] = customer;
            }

            var houseCode = r.GetString(6).Trim();
            var status = r.GetString(10);
            var booking = new Booking
            {
                Reference = r.GetString(1) is { Length: > 0 } reference ? reference : $"BID-{oldId}",
                Customer = customer,
                House = houses.TryGetValue(houseCode, out var house)
                    ? house : throw new InvalidDataException($"Booking row {oldId} points at unknown house {houseCode}."),
                TotalRent = r.GetDecimal(7),
                Plan = Enum.TryParse<RentPlan>(r.GetString(8), true, out var plan)
                    ? plan : throw new InvalidDataException($"Booking row {oldId} has unknown plan '{r.GetString(8)}'."),
                Status = status == "Rent Approved"
                    ? BookingStatus.Active : throw new InvalidDataException($"Booking row {oldId} has unknown status '{status}'."),
                StartDate = DateOnly.FromDateTime(r.GetDateTime(11)),
                EndDate = DateOnly.FromDateTime(r.GetDateTime(12)),
                BookedOn = DateOnly.FromDateTime(r.GetDateTime(13)),
            };
            if (r.GetString(9) == "Paid" && booking.TotalRent > 0)
                booking.Payments.Add(new Payment { Amount = booking.TotalRent, PaidOn = booking.BookedOn });
            bookings.Add(booking);
        }
        return (customers.Values.ToList(), bookings);
    }
}
