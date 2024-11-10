namespace ScooterBooking.Application.ViewModels.BookingViewModel
{
    public record UpdateBookingViewModel(
        DateTime StartsAt,
        DateTime EndsAt,
        decimal TotalPrice,
        Guid UserId,
        Guid ScooterId);
}
