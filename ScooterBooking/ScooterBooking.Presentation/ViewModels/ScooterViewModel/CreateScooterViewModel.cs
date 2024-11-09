using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Presentation.ViewModels.ScooterViewModel
{
    public record CreateScooterViewModel(
        string Brand,
        string Model,
        string Color,
        ScooterStatus Status,
        Guid? InsuranceViewModelId,
        Guid? LocationViewModel
    );
}
