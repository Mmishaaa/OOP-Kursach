using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Presentation.ViewModels.InsuranceViewModel
{
    public record UpdateInsuranceViewModel(
        InsuranceType Type,
        string Description,
        decimal Cost,
        IReadOnlyCollection<Guid> ScooterIds);
}
