using Microsoft.Extensions.DependencyInjection;
using ScooterBooking.Application.Services;
using ScooterBooking.Domain.Interfaces.Services;

namespace ScooterBooking.Application.DI
{
    public static class ApplicationRegister
    {
        public static void AddApplicationDependencies(this IServiceCollection services)
        {
            services.AddScoped<IBookingService, BookingService>();
            services.AddScoped<IInsuranceService, InsuranceService>();
            services.AddScoped<ILocationService, LocationService>();
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<IPricingService, PricingService>();
            services.AddScoped<IReviewService, ReviewService>();
            services.AddScoped<IScooterService, ScooterService>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}
