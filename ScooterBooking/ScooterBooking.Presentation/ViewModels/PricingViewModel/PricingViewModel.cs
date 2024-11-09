namespace ScooterBooking.Presentation.ViewModels.PricingViewModel
{
    public record PricingViewModel(
        Guid Id,
        decimal SpeedPriceHour,
        int MaxSpeed,
        ScooterViewModel.ScooterViewModel? Scooter);
}
