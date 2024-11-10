using ScooterBooking.Application.ViewModels.ScooterViewModel;

namespace ScooterBooking.Application.ViewModels.LocationViewModel
{
    public record ShortLocationViewModel(
        Guid Id,
        string City,
        string Street,
        int BuildingNumber,
        IReadOnlyCollection<ShortScooterViewModel> Scooters);
}
