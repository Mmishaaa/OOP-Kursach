using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Presentation.ViewModels.InsuranceViewModel
{
    public class CreateInsuranceViewModel(
        InsuranceType Type,
        string Description,
        decimal Cost,
        IReadOnlyCollection<Guid> ScooterIds);
}
