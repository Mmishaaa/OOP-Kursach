using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Presentation.ViewModels.PaymentViewModel
{
    public record ShortPaymentViewModel(
        Guid Id,
        PaymentMethod Method,
        PaymentStatus Status
    );
}
