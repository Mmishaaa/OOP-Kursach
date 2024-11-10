using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Application.ViewModels.PaymentViewModel
{
    public record CreatePaymentViewModel(
        PaymentMethod Method,
        Guid BookingId);
}
