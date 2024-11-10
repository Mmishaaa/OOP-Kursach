using FluentValidation;
using ScooterBooking.Application.ViewModels.PaymentViewModel;

namespace ScooterBooking.Presentation.Validators.Payment
{
    public class CreatePaymentViewModelValidator : AbstractValidator<CreatePaymentViewModel>
    {
        public CreatePaymentViewModelValidator()
        {
            RuleFor(x => x.BookingId)
                .NotEmpty()
                .WithMessage("Booking ID is required.");
        }
    }
}
