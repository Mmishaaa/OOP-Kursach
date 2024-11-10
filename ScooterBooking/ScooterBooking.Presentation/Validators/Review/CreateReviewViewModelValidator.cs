using FluentValidation;
using ScooterBooking.Application.ViewModels.ReviewViewModel;

namespace ScooterBooking.Presentation.Validators.Review
{
    public class CreateReviewViewModelValidator : AbstractValidator<CreateReviewViewModel>
    {
        public CreateReviewViewModelValidator()
        {

            RuleFor(x => x.Text)
                .NotEmpty()
                .WithMessage("Review text is required.")
                .MaximumLength(1000)
                .WithMessage("Review text must be 1000 characters or fewer.");

            RuleFor(x => x.UserId)
                .NotNull()
                .WithMessage("User ID is required.")
                .NotEqual(Guid.Empty)
                .WithMessage("User ID cannot be an empty GUID.");

            RuleFor(x => x.BookingId)
                .NotNull()
                .WithMessage("Booking ID is required.")
                .NotEqual(Guid.Empty)
                .WithMessage("Booking ID cannot be an empty GUID.");
        }
    }
}
