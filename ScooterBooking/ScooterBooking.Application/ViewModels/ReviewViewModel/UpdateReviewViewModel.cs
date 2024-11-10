using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Application.ViewModels.ReviewViewModel
{
    public record UpdateReviewViewModel(
        Rating Rating,
        string Text,
        Guid? UserId,
        Guid? BookingId);
}
