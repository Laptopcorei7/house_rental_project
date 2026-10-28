using System.Data.SqlClient;

namespace RentalProject
{
    // What staff picked on the Book House screen, handed to the client details dialog.
    // Plan is "Daily" or "Monthly", the same text that is saved in customers.rent_plan.
    internal record Booking(string HouseId, DateTime Start, DateTime End, string Plan,
        decimal MonthlyRent, decimal DailyRent, decimal Deposit)
    {
        public bool IsDaily => Plan == "Daily";
        // Two bookings of a house overlap when one starts before the other ends.
        // The end date is the move-out day, so a new booking may start on it.
        public const string OverlapSql =
            "SELECT 1 FROM customers WHERE house_id = @houseID AND status = 'Rent Approved' " +
            "AND date_start < @dateEnd AND date_end > @dateStart";

        // Every started month is charged in full: 1 Jan to 15 Feb is 2 months.
        public int Months
        {
            get
            {
                int months = (End.Year - Start.Year) * 12 + End.Month - Start.Month;
                if (Start.AddMonths(months) > End) months--;
                if (Start.AddMonths(months) < End) months++;
                return months;
            }
        }

        // Nights stayed: 28 Oct to 31 Oct is 3 days.
        public int Days => (End - Start).Days;

        public decimal Total => IsDaily ? DailyRent * Days : MonthlyRent * Months;

        // The rate as printed on the receipt, e.g. "2000.50 / month".
        public string RateText => IsDaily ? $"{DailyRent:0.00} / day" : $"{MonthlyRent:0.00} / month";

        // Returns why this booking can't be made, or null when it can.
        public string? FindProblem()
        {
            if (Start < DateTime.Today) return "The start date can't be in the past.";
            if (End <= Start) return "The end date must be after the start date.";
            if (IsDaily && DailyRent <= 0) return "This house has no daily rent set. Ask an admin to add one.";

            using SqlConnection connect = new SqlConnection(Db.ConnectionString);
            connect.Open();

            using (SqlCommand houseCmd = new SqlCommand(
                "SELECT status FROM addHouse WHERE house_id = @houseID AND date_delete IS NULL", connect))
            {
                houseCmd.Parameters.AddWithValue("@houseID", HouseId);
                if (houseCmd.ExecuteScalar() as string != "Available")
                    return "This house is not open for booking.";
            }

            using (SqlCommand overlapCmd = new SqlCommand(OverlapSql, connect))
            {
                AddDateParameters(overlapCmd);
                if (overlapCmd.ExecuteScalar() != null)
                    return "This house is already booked for some of those dates.";
            }

            return null;
        }

        public void AddDateParameters(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@houseID", HouseId);
            cmd.Parameters.AddWithValue("@dateStart", Start);
            cmd.Parameters.AddWithValue("@dateEnd", End);
        }
    }
}
