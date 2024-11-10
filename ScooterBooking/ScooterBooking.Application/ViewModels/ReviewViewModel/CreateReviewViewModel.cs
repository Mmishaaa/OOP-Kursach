using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Application.ViewModels.ReviewViewModel
{
    public record CreateReviewViewModel(
        Rating Rating,
        string Text,
        Guid? UserId,
        Guid? BookingId);
}
