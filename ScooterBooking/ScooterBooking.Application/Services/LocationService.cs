using AutoMapper;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Repositories;
using ScooterBooking.Domain.Interfaces.Services;

namespace ScooterBooking.Application.Services
{
    public class LocationService(ILocationRepository locationRepository, IMapper mapper)
        : GenericService<LocationEntity>(locationRepository, mapper), ILocationService
    {
    }
}
