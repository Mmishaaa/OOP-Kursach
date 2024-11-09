using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Presentation.ViewModels.PaymentViewModel
{
    public record CreatePaymentViewModel(
        PaymentMethod Method,
        PaymentStatus Status,
        Guid BookingViewModelId);
}
