using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Presentation.ViewModels.InsuranceViewModel
{
    public record ShortInsuranceViewModel(
        Guid Id,
        InsuranceType Type,
        string Description,
        decimal Cost
    );
}
