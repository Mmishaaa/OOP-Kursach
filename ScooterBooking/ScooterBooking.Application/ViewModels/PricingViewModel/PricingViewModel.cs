namespace ScooterBooking.Application.ViewModels.PricingViewModel
{
    public record PricingViewModel(
        Guid Id,
        decimal SpeedPriceHour,
        int MaxSpeed,
        ScooterViewModel.ScooterViewModel? Scooter);
}
