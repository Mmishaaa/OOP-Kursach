using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Application.ViewModels.ScooterViewModel
{
    public record CreateScooterViewModel(
        string Brand,
        string Model,
        string Color,
        ScooterStatus Status,
        Guid InsuranceId,
        Guid LocationId
    );
}
