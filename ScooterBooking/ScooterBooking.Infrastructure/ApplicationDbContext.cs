using Microsoft.EntityFrameworkCore;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Infrastructure.Interceptors;

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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
                .AddInterceptors(new UpdateAuditableInterceptor());
        }

        public DbSet<BookingEntity> Bookings { get; set; }
        public DbSet<InsuranceEntity> Insurances { get; set; }
        public DbSet<LocationEntity> Locations { get; set; }
        public DbSet<PaymentEntity> Payments { get; set; }
        public DbSet<PricingEntity> Prices { get; set; }
        public DbSet<ReviewEntity> Reviews { get; set; }
        public DbSet<ScooterEntity> Scooters { get; set; }
        public DbSet<UserEntity> Users { get; set; }
    }
}
