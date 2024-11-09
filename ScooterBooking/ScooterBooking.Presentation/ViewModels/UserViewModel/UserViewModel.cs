namespace ScooterBooking.Presentation.ViewModels.UserViewModel
{
    public record UserViewModel(
        Guid Id,
        string FirstName,
        string LastName,
        string Email,
        int PhoneNumber,
        List<BookingViewModel.BookingViewModel> Bookings
    );
}