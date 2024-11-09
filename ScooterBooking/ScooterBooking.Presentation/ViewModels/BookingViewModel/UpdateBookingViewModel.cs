namespace ScooterBooking.Presentation.ViewModels.BookingViewModel
{
    public record UpdateBookingViewModel(
        DateTime StartsAt,
        DateTime EndsAt,
        decimal TotalPrice,
        Guid UserId,
        Guid ScooterId);
}
