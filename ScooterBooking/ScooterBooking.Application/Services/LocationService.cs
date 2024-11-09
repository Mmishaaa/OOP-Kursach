using AutoMapper;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Repositories;
using ScooterBooking.Domain.Interfaces.Services;

namespace ScooterBooking.Application.Services
{
    public class LocationService(IGenericRepository<LocationEntity> genericRepository, IMapper mapper)
        : GenericService<LocationEntity>(genericRepository, mapper), ILocationService
    {
    }
}
