namespace ScooterBooking.Presentation.ViewModels.UserViewModel
{
    public record CreateUserViewModel(
        string FirstName,
        string LastName,
        string Email,
        int PhoneNumber,
        List<Guid> BookingIds);
}
