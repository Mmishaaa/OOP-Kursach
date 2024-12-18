﻿namespace ScooterBooking.Application.ViewModels.LocationViewModel
{
    public record UpdateLocationViewModel(
        string City,
        string Street,
        int BuildingNumber,
        IReadOnlyCollection<Guid> ScooterIds);
}
