using AutoMapper;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Repositories;
using ScooterBooking.Domain.Interfaces.Services;

namespace ScooterBooking.Application.Services
{
    public class ScooterService(IGenericRepository<ScooterEntity> genericRepository, IMapper mapper) :
        GenericService<ScooterEntity>(genericRepository, mapper), IScooterService
    {
    }
}
