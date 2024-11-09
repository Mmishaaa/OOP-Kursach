namespace ScooterBooking.Presentation.ViewModels.UserViewModel
{
    public record ShortUserViewModel(
        Guid Id,
        string FirstName,
        string LastName,
        string Email,
        int PhoneNumber
    );
}
