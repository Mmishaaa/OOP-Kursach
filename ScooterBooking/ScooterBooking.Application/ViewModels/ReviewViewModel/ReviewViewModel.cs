using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Application.ViewModels.ReviewViewModel
{
    public record ReviewViewModel(
        Guid Id,
        Rating Rating,
        string Text,
        DateTime CreatedAt,
        UserViewModel.UserViewModel? User,
        BookingViewModel.BookingViewModel? Booking);
}