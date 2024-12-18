﻿namespace ScooterBooking.Application.ViewModels.LocationViewModel
{
    public record LocationViewModel(
        Guid Id,
        string City,
        string Street,
        int BuildingNumber,
        IReadOnlyCollection<ScooterViewModel.ScooterViewModel> Scooters);
}
