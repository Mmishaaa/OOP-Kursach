using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Presentation.ViewModels.ScooterViewModel
{
    public record UpdateScooterViewModel(
        string Brand,
        string Model,
        string Color,
        ScooterStatus Status,
        Guid? InsuranceViewModelId,
        Guid? LocationViewModel
    );
}
