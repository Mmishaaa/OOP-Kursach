using FluentValidation;
using ScooterBooking.Application.ViewModels.InsuranceViewModel;

namespace ScooterBooking.Presentation.Validators.Insurance
{
    public class UpdateInsuranceViewModelValidator : AbstractValidator<UpdateInsuranceViewModel>
    {
        public UpdateInsuranceViewModelValidator()
        {
            RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage("Description is required.")
                .MaximumLength(500)
                .WithMessage("Description must be 500 characters or fewer.");

            RuleFor(x => x.Cost)
                .GreaterThan(0)
                .WithMessage("Cost must be greater than zero.");
        }
    }
}
