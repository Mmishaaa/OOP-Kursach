using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ScooterBooking.Domain.Entities;

namespace ScooterBooking.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)
        {
            if (Database.IsRelational())
            {
                Database.Migrate();
            }
        }

        //public DbSet<BookingEntity> Bookings { get; set; }
        //public DbSet<InsuranceEntity> Insurances { get; set; }
        //public DbSet<LocationEntity> Locations { get; set; }
        //public DbSet<PaymentEntity> Payments { get; set; }
        //public DbSet<PricingModel> Prices { get; set; }
        //public DbSet<ReviewEntity> Reviews { get; set; }
        //public DbSet<ScooterEntity> Scooters { get; set; }
        //public DbSet<UserEntity> Users { get; set; }
    }
}
