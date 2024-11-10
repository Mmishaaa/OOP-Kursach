using FluentValidation;
using ScooterBooking.Application.ViewModels.ScooterViewModel;

namespace ScooterBooking.Presentation.Validators.Scooter
{
    public class UpdateScooterViewModelValidator : AbstractValidator<UpdateScooterViewModel>
    {
        public UpdateScooterViewModelValidator()
        {
            RuleFor(x => x.Brand)
                .NotEmpty()
                .WithMessage("Brand is required.")
                .MaximumLength(100)
                .WithMessage("Brand must be 100 characters or fewer.");

            RuleFor(x => x.Model)
                .NotEmpty()
                .WithMessage("Model is required.")
                .MaximumLength(100)
                .WithMessage("Model must be 100 characters or fewer.");

            RuleFor(x => x.Color)
                .NotEmpty()
                .WithMessage("Color is required.")
                .MaximumLength(50)
                .WithMessage("Color must be 50 characters or fewer.");

            RuleFor(x => x.InsuranceId)
                .NotNull()
                .WithMessage("Insurance ID is required.")
                .NotEqual(Guid.Empty)
                .WithMessage("Insurance ID cannot be an empty GUID.");

            RuleFor(x => x.LocationId)
                .NotNull()
                .WithMessage("Location ID is required.")
                .NotEqual(Guid.Empty)
                .WithMessage("Location ID cannot be an empty GUID.");
        }
    }
}
