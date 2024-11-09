using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Presentation.ViewModels.ReviewViewModel
{
    public record CreateReviewViewModel(
        Rating Rating,
        string Text,
        Guid? UserViewModelId,
        Guid? BookingViewModelId);
}
