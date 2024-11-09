namespace ScooterBooking.Presentation.ViewModels.LocationViewModel
{
    public record CreateLocationViewModel(
        string City,
        string Street,
        int BuildingNumber,
        IReadOnlyCollection<Guid> ScooterIds);
}
