namespace ScooterBooking.Application.ViewModels.BookingViewModel
{
    public record ShortBookingViewModel(
        Guid Id,
        DateTime StartsAt,
        DateTime EndsAt,
        decimal TotalPrice
    );
}