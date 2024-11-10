using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using ScooterBooking.Domain.Interfaces.Repositories;
using ScooterBooking.Infrastructure.Repositories;

namespace ScooterBooking.Infrastructure.DI
{
    public static class InfrastructureRegister
    {
        public static void AddInfrastructureDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<DatabaseOptions>(options =>
            {
                configuration.GetSection(nameof(DatabaseOptions)).Bind(options);
            });

            services.AddDbContext<ApplicationDbContext>((serviceProvider, options) =>
            {
                var dbOptions = serviceProvider.GetRequiredService<IOptions<DatabaseOptions>>().Value;
                options.UseMySql(
                    dbOptions.ConnectionString,
                    ServerVersion.AutoDetect(dbOptions.ConnectionString), 
                    options => options.EnableRetryOnFailure(
                        maxRetryCount: 5,
                        maxRetryDelay: System.TimeSpan.FromSeconds(30),
                        errorNumbersToAdd: null)
                );
            });

            services.AddScoped<IBookingRepository, BookingRepository>();
            services.AddScoped<IInsuranceRepository, InsuranceRepository>();
            services.AddScoped<ILocationRepository, LocationRepository>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped<IPricingRepository, PricingRepository>();
            services.AddScoped<IReviewRepository, ReviewRepository>();
            services.AddScoped<IScooterRepository, ScooterRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
