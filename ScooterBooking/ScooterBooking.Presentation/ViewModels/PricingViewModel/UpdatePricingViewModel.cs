namespace ScooterBooking.Presentation.ViewModels.PricingViewModel
{
    public record UpdatePricingViewModel(
        decimal SpeedPriceHour,
        int MaxSpeed,
        Guid? ScooterId);
}
