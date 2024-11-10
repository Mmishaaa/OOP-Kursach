using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Application.ViewModels.PaymentViewModel
{
    public record UpdatePaymentViewModel(
        PaymentMethod Method,
        decimal EnteredPrice,
        Guid BookingId);
}
