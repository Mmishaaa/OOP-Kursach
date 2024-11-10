using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Application.ViewModels.PaymentViewModel
{
    public record ShortPaymentViewModel(
        Guid Id,
        PaymentMethod Method,
        PaymentStatus Status
    );
}
