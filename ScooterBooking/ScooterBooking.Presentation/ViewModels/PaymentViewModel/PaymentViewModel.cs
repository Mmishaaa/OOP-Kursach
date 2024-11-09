using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Presentation.ViewModels.PaymentViewModel
{
    public record PaymentViewModel(
        Guid Id,
        PaymentMethod Method,
        PaymentStatus Status,
        BookingViewModel.BookingViewModel BookingViewModel);
}
