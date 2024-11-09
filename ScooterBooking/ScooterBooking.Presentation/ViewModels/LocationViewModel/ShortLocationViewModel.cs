namespace ScooterBooking.Presentation.ViewModels.LocationViewModel
{
    public record ShortLocationViewModel(
        Guid Id,
        string City,
        string Street,
        int BuildingNumber,
        IReadOnlyCollection<ShortScooterViewModel> Scooters);
}
