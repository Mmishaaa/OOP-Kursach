using FluentValidation;
using ScooterBooking.Application.ViewModels.PricingViewModel;

namespace ScooterBooking.Presentation.Validators.Pricing
{
    public class CreatePricingViewModelValidator : AbstractValidator<CreatePricingViewModel>
    {
        public CreatePricingViewModelValidator()
        {
            RuleFor(x => x.SpeedPriceHour)
                .GreaterThan(0)
                .WithMessage("Speed price per hour must be greater than zero.");

            RuleFor(x => x.MaxSpeed)
                .GreaterThan(0)
                .WithMessage("Max speed must be greater than zero.")
                .LessThanOrEqualTo(100)
                .WithMessage("Max speed must be 100 or lower.");

            RuleFor(x => x.ScooterId)
                .NotEmpty()
                .WithMessage("Booking ID is required.");
        }
    }
}
