using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Application.ViewModels.ScooterViewModel
{
    public record ScooterViewModel(
        Guid Id,
        string Brand,
        string Model,
        string Color,
        ScooterStatus Status,
        InsuranceViewModel.InsuranceViewModel? Insurance,
        LocationViewModel.LocationViewModel? Location
    );
}