using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Application.ViewModels.InsuranceViewModel
{
    public record InsuranceViewModel(
        Guid Id,
        InsuranceType Type,
        string Description,
        decimal Cost,
        IReadOnlyCollection<ScooterViewModel.ScooterViewModel> Scooters
    );
}
