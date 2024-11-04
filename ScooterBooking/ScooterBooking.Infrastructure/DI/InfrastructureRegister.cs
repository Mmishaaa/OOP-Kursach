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

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                services.AddDbContext<ApplicationDbContext>(option =>
                    option.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            });
        }
    }
}
