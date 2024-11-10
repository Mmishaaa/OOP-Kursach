using FluentValidation;
using ScooterBooking.Application.ViewModels.PaymentViewModel;

namespace ScooterBooking.Presentation.Validators.Payment
{
    public class UpdatePaymentViewModelValidator : AbstractValidator<UpdatePaymentViewModel>
    {
        public UpdatePaymentViewModelValidator()
        {
            RuleFor(x => x.BookingId)
                .NotEmpty()
                .WithMessage("Booking ID is required.");
        }
    }
}
