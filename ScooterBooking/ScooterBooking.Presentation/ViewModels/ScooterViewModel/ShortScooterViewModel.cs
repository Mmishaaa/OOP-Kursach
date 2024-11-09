using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Presentation.ViewModels.ScooterViewModel
{
    public record ShortScooterViewModel(
        Guid Id,
        string Brand,
        string Model,
        string Color,
        ScooterStatus Status
    );
}
