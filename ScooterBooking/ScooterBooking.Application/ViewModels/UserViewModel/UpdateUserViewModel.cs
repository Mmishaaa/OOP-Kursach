namespace ScooterBooking.Application.ViewModels.UserViewModel
{
    public record UpdateUserViewModel(
        string FirstName,
        string LastName,
        string Email,
        int PhoneNumber,
        List<Guid>? BookingIds);
}
