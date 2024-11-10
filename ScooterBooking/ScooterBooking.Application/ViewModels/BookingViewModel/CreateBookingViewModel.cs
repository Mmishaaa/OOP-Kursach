namespace ScooterBooking.Application.ViewModels.BookingViewModel
{
    public record CreateBookingViewModel(
        DateTime StartsAt,
        DateTime EndsAt,
        //decimal TotalPrice,
        Guid UserId,
        Guid ScooterId);
}
