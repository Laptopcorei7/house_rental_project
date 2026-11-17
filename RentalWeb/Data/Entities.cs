namespace RentalWeb.Data;

public enum HouseStatus { Available, Unavailable }
public enum RentPlan { Daily, Monthly }
public enum BookingStatus { Active, Completed, Cancelled }
public enum UserRole { Admin, Staff }

public class House
{
    public int Id { get; set; }
    // The ID staff see and type, such as HD-001.
    public string Code { get; set; } = "";
    public string Name { get; set; } = "";
    public string? Description { get; set; }
    public string Address { get; set; } = "";
    public int Bedrooms { get; set; }
    public int Bathrooms { get; set; }
    public decimal MonthlyRent { get; set; }
    public decimal DailyRent { get; set; }
    public decimal Deposit { get; set; }
    // File name only; the file lives in wwwroot/images/houses.
    public string? ImageFileName { get; set; }
    public DateOnly AvailableFrom { get; set; }
    public HouseStatus Status { get; set; }
    public DateOnly? UpdatedOn { get; set; }
    // Set when an admin removes the house; the row stays so old bookings keep their house.
    public DateOnly? DeletedOn { get; set; }

    public List<Booking> Bookings { get; set; } = new();
}

public class Customer
{
    public int Id { get; set; }
    public string FullName { get; set; } = "";
    public string Email { get; set; } = "";
    public string Phone { get; set; } = "";
    public string Gender { get; set; } = "";

    public List<Booking> Bookings { get; set; } = new();
}

public class Booking
{
    public int Id { get; set; }
    // Printed on receipts, such as BID-3.
    public string Reference { get; set; } = "";
    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;
    public int HouseId { get; set; }
    public House House { get; set; } = null!;
    public RentPlan Plan { get; set; }
    public decimal TotalRent { get; set; }
    public DateOnly StartDate { get; set; }
    // Move-out day: the next booking may start on this date.
    public DateOnly EndDate { get; set; }
    public DateOnly BookedOn { get; set; }
    public BookingStatus Status { get; set; }

    public List<Payment> Payments { get; set; } = new();
}

public class Payment
{
    public int Id { get; set; }
    public int BookingId { get; set; }
    public Booking Booking { get; set; } = null!;
    public decimal Amount { get; set; }
    public DateOnly PaidOn { get; set; }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Email { get; set; } = "";
    public string PasswordHash { get; set; } = "";
    public UserRole Role { get; set; }
    public bool IsActive { get; set; } = true;
    public int FailedLoginCount { get; set; }
    public DateTime? LockedUntilUtc { get; set; }
    // Raised on password change or deactivation; sign-in cookies carrying an older value stop working.
    public int SecurityVersion { get; set; }
    public DateOnly CreatedOn { get; set; }
}
