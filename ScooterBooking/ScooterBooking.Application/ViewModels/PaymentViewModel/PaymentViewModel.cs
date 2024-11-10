using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Application.ViewModels.PaymentViewModel
{
    public record PaymentViewModel(
        Guid Id,
        PaymentMethod Method,
        PaymentStatus Status,
        BookingViewModel.BookingViewModel Booking);
}
