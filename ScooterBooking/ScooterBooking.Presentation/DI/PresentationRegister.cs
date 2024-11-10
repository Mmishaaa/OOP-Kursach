using FluentValidation;
using ScooterBooking.Presentation.Mapper;
using ScooterBooking.Application.ViewModels.BookingViewModel;
using ScooterBooking.Application.ViewModels.InsuranceViewModel;
using ScooterBooking.Application.ViewModels.LocationViewModel;
using ScooterBooking.Application.ViewModels.PaymentViewModel;
using ScooterBooking.Application.ViewModels.PricingViewModel;
using ScooterBooking.Application.ViewModels.ReviewViewModel;
using ScooterBooking.Application.ViewModels.ScooterViewModel;
using ScooterBooking.Application.ViewModels.UserViewModel;
using ScooterBooking.Presentation.Validators.Booking;
using ScooterBooking.Presentation.Validators.Insurance;
using ScooterBooking.Presentation.Validators.Location;
using ScooterBooking.Presentation.Validators.Payment;
using ScooterBooking.Presentation.Validators.Pricing;
using ScooterBooking.Presentation.Validators.Review;
using ScooterBooking.Presentation.Validators.Scooter;
using ScooterBooking.Presentation.Validators.User;

namespace ScooterBooking.Presentation.DI
{
    public static class PresentationRegister
    {
        public static void AddPresentationDependencies(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));

            services.AddScoped<IValidator<CreateBookingViewModel>, CreateBookingViewModelValidator>();
            services.AddScoped<IValidator<UpdateBookingViewModel>, UpdateBookingViewModelValidator>();
            
            services.AddScoped<IValidator<CreateInsuranceViewModel>, CreateInsuranceViewModelValidator>();
            services.AddScoped<IValidator<UpdateInsuranceViewModel>, UpdateInsuranceViewModelValidator>();

            services.AddScoped<IValidator<CreateLocationViewModel>, CreateLocationViewModelValidator>();
            services.AddScoped<IValidator<UpdateLocationViewModel>, UpdateLocationViewModelValidator>();

            services.AddScoped<IValidator<CreatePaymentViewModel>, CreatePaymentViewModelValidator>();
            services.AddScoped<IValidator<UpdatePaymentViewModel>, UpdatePaymentViewModelValidator>();

            services.AddScoped<IValidator<CreatePricingViewModel>, CreatePricingViewModelValidator>();
            services.AddScoped<IValidator<UpdatePricingViewModel>, UpdatePricingViewModelValidator>();

            services.AddScoped<IValidator<CreateReviewViewModel>, CreateReviewViewModelValidator>();
            services.AddScoped<IValidator<UpdateReviewViewModel>, UpdateReviewViewModelValidator>();

            services.AddScoped<IValidator<CreateScooterViewModel>, CreateScooterViewModelValidator>();
            services.AddScoped<IValidator<UpdateScooterViewModel>, UpdateScooterViewModelValidator>();

            services.AddScoped<IValidator<CreateUserViewModel>, CreateUserViewModelValidator>();
            services.AddScoped<IValidator<UpdateUserViewModel>, UpdateUserViewModelValidator>();
        }
    }
}
