namespace ScooterBooking.Presentation.ViewModels.PricingViewModel
{
    public record ShortPricingViewModel(
        Guid Id,
        decimal SpeedPriceHour,
        int MaxSpeed
    );
}
