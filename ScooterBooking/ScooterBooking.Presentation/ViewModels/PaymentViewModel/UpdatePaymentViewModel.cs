using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Presentation.ViewModels.PaymentViewModel
{
    public record UpdatePaymentViewModel(
        PaymentMethod Method,
        PaymentStatus Status,
        Guid BookingViewModelId);
}
