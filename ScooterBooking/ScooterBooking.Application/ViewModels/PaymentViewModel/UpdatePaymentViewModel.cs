using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Application.ViewModels.PaymentViewModel
{
    public record UpdatePaymentViewModel(
        PaymentMethod Method,
        PaymentStatus Status,
        Guid BookingId);
}
