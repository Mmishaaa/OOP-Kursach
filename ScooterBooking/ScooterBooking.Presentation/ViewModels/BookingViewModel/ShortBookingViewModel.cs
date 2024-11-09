namespace ScooterBooking.Presentation.ViewModels.BookingViewModel
{
    public class ShortBookingViewModel(
        Guid Id,
        DateTime StartsAt,
        DateTime EndsAt,
        decimal TotalPrice
    );
}
