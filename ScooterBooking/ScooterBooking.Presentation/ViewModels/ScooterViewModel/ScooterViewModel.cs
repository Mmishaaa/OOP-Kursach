using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Presentation.ViewModels.ScooterViewModel
{
    public record ScooterViewModel(
        Guid Id,
        string Brand,
        string Model,
        string Color,
        ScooterStatus Status,
        InsuranceViewModel.InsuranceViewModel? InsuranceViewModel,
        LocationViewModel.LocationViewModel? LocationViewModel
    );
}