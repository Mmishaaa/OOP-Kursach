using FluentValidation;
using ScooterBooking.Application.ViewModels.UserViewModel;

namespace ScooterBooking.Presentation.Validators.User
{
    public class UpdateUserViewModelValidator : AbstractValidator<UpdateUserViewModel>
    {
        public UpdateUserViewModelValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithMessage("First name is required.")
                .MaximumLength(100)
                .WithMessage("First name must be 100 characters or fewer.");

            RuleFor(x => x.LastName)
                .NotEmpty()
                .WithMessage("Last name is required.")
                .MaximumLength(100)
                .WithMessage("Last name must be 100 characters or fewer.");

            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("Email is required.")
                .EmailAddress()
                .WithMessage("Email must be a valid email address.");

            RuleFor(x => x.PhoneNumber)
                .GreaterThan(0)
                .WithMessage("Phone number must be a valid positive number.");
        }
    }
}
