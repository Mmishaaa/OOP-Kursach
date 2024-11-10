using FluentValidation;
using ScooterBooking.Application.ViewModels.BookingViewModel;

namespace ScooterBooking.Presentation.Validators.Booking
{
    public class UpdateBookingViewModelValidator : AbstractValidator<UpdateBookingViewModel>
    {
        public UpdateBookingViewModelValidator()
        {
            RuleFor(x => x.StartsAt)
                .LessThan(x => x.EndsAt)
                .WithMessage("The start date must be earlier than the end date.");

            RuleFor(x => x.EndsAt)
                .GreaterThan(x => x.StartsAt)
                .WithMessage("The end date must be later than the start date.");

            RuleFor(x => x.TotalPrice)
                .GreaterThan(0)
                .WithMessage("The total price must be greater than zero.");

            RuleFor(x => x.UserId)
                .NotEmpty()
                .WithMessage("User ID is required.");

            RuleFor(x => x.ScooterId)
                .NotEmpty()
                .WithMessage("Scooter ID is required.");
        }
    }
}
