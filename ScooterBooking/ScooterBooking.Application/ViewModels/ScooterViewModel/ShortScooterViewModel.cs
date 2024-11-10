using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Application.ViewModels.ScooterViewModel
{
    public record ShortScooterViewModel(
        Guid Id,
        string Brand,
        string Model,
        string Color,
        ScooterStatus Status
    );
}
