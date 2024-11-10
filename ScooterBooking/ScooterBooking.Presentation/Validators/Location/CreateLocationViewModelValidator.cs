using FluentValidation;
using ScooterBooking.Application.ViewModels.LocationViewModel;

namespace ScooterBooking.Presentation.Validators.Location
{
    public class CreateLocationViewModelValidator : AbstractValidator<CreateLocationViewModel>
    {
        public CreateLocationViewModelValidator()
        {
            RuleFor(x => x.City)
                .NotEmpty()
                .WithMessage("City is required.")
                .MaximumLength(100)
                .WithMessage("City name must be 100 characters or fewer.");

            RuleFor(x => x.Street)
                .NotEmpty()
                .WithMessage("Street is required.")
                .MaximumLength(100)
                .WithMessage("Street name must be 100 characters or fewer.");

            RuleFor(x => x.BuildingNumber)
                .GreaterThan(0)
                .WithMessage("Building number must be greater than zero.");
        }
    }
}
