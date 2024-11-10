using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Application.ViewModels.InsuranceViewModel
{
    public record CreateInsuranceViewModel(
        InsuranceType Type,
        string Description,
        decimal Cost
    );
}
