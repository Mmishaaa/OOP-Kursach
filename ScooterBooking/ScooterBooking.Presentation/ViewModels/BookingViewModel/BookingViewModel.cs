namespace ScooterBooking.Presentation.ViewModels.BookingViewModel
{
    public record BookingViewModel(
        Guid Id,
        DateTime StartsAt,
        DateTime EndsAt,
        decimal TotalPrice,
        UserViewModel.UserViewModel User,
        ScooterViewModel.ScooterViewModel Scooter
    );
}
