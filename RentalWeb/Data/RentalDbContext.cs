using Microsoft.EntityFrameworkCore;

namespace RentalWeb.Data;

public class RentalDbContext(DbContextOptions<RentalDbContext> options) : DbContext(options)
{
    public DbSet<House> Houses => Set<House>();
    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Booking> Bookings => Set<Booking>();
    public DbSet<Payment> Payments => Set<Payment>();
    public DbSet<User> Users => Set<User>();

    protected override void ConfigureConventions(ModelConfigurationBuilder builder)
    {
        builder.Properties<decimal>().HavePrecision(10, 2);
        builder.Properties<string>().HaveMaxLength(255);
        // Enums are stored by name, so the database stays readable and reordering an enum changes nothing.
        builder.Properties<Enum>().HaveConversion<string>().HaveMaxLength(20);
    }

    protected override void OnModelCreating(ModelBuilder model)
    {
        model.Entity<House>(e =>
        {
            e.HasIndex(h => h.Code).IsUnique();
            e.Property(h => h.Code).HasMaxLength(50);
            e.Property(h => h.Description).HasMaxLength(4000);
        });

        model.Entity<Customer>(e =>
        {
            e.HasIndex(c => c.Email).IsUnique();
            e.Property(c => c.Phone).HasMaxLength(50);
            e.Property(c => c.Gender).HasMaxLength(20);
        });

        model.Entity<Booking>(e =>
        {
            e.HasIndex(b => b.Reference).IsUnique();
            e.Property(b => b.Reference).HasMaxLength(50);
            // Bookings are history: deleting a house or customer must not delete them.
            e.HasOne(b => b.House).WithMany(h => h.Bookings).OnDelete(DeleteBehavior.Restrict);
            e.HasOne(b => b.Customer).WithMany(c => c.Bookings).OnDelete(DeleteBehavior.Restrict);
            e.HasIndex(b => new { b.HouseId, b.StartDate, b.EndDate });
            e.ToTable(t => t.HasCheckConstraint("CK_Bookings_Dates", "[EndDate] > [StartDate]"));
        });

        model.Entity<Payment>(e =>
        {
            e.HasOne(p => p.Booking).WithMany(b => b.Payments).OnDelete(DeleteBehavior.Restrict);
            e.ToTable(t => t.HasCheckConstraint("CK_Payments_Amount", "[Amount] > 0"));
        });

        model.Entity<User>(e =>
        {
            e.HasIndex(u => u.Email).IsUnique();
            e.Property(u => u.PasswordHash).HasMaxLength(200);
        });
    }
}
