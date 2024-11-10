using AutoMapper;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Repositories;
using ScooterBooking.Domain.Interfaces.Services;

namespace ScooterBooking.Application.Services
{
    public class ScooterService(IScooterRepository scooterRepository, IMapper mapper) :
        GenericService<ScooterEntity>(scooterRepository, mapper), IScooterService
    {
    }
}
