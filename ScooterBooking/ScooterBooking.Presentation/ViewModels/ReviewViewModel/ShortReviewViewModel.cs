using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Presentation.ViewModels.ReviewViewModel
{
    public record ShortReviewViewModel(
        Guid Id,
        Rating Rating,
        string Text,
        DateTime CreatedAt
    );
}
