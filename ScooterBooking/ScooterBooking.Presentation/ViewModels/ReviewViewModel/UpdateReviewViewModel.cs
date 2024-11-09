using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Presentation.ViewModels.ReviewViewModel
{
    public record UpdateReviewViewModel(
        Rating Rating,
        string Text,
        Guid? UserViewModelId,
        Guid? BookingViewModelId);
}
