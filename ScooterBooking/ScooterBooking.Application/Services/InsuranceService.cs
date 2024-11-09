using AutoMapper;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Repositories;
using ScooterBooking.Domain.Interfaces.Services;

namespace ScooterBooking.Application.Services
{
    public class InsuranceService(IGenericRepository<InsuranceEntity> genericRepository, IMapper mapper)
        : GenericService<InsuranceEntity>(genericRepository, mapper), IInsuranceService
    {
    }
}
