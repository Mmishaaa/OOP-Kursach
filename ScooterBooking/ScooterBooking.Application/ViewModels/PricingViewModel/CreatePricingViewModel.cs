namespace ScooterBooking.Application.ViewModels.PricingViewModel
{
    public record CreatePricingViewModel(
        decimal SpeedPriceHour,
        int MaxSpeed,
        Guid ScooterId);
}
