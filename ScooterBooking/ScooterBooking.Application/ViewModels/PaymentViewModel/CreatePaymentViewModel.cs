using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Application.ViewModels.PaymentViewModel
{
    public record CreatePaymentViewModel(
        PaymentMethod Method,
        PaymentStatus Status,
        Guid BookingId);
}
