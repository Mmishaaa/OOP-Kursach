using AutoMapper;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Repositories;
using ScooterBooking.Domain.Interfaces.Services;

namespace ScooterBooking.Application.Services
{
    public class PricingService(IGenericRepository<PricingEntity> genericRepository, IMapper mapper) :
        GenericService<PricingEntity>(genericRepository, mapper), IPricingService
    {
    }
}
