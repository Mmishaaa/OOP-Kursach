using AutoMapper;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Repositories;
using ScooterBooking.Domain.Interfaces.Services;

namespace ScooterBooking.Application.Services
{
    public class PricingService(IPricingRepository pricingRepository, IMapper mapper) :
        GenericService<PricingEntity>(pricingRepository, mapper), IPricingService
    {
    }
}
