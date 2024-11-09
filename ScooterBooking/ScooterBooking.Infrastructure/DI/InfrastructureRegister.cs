using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

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
        }
    }
}
