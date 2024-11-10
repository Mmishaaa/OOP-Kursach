namespace ScooterBooking.Application.ViewModels.PricingViewModel
{
    public record ShortPricingViewModel(
        Guid Id,
        decimal SpeedPriceHour,
        int MaxSpeed
    );
}
