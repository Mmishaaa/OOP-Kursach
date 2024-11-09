using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Presentation.ViewModels.ReviewViewModel
{
    public record ReviewViewModel(
        Guid Id,
        Rating Rating,
        string Text,
        DateTime CreatedAt,
        UserViewModel.UserViewModel? UserViewModel,
        BookingViewModel.BookingViewModel BookingViewModel);
}