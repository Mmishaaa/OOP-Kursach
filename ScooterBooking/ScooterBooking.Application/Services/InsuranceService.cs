using AutoMapper;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Repositories;
using ScooterBooking.Domain.Interfaces.Services;

namespace ScooterBooking.Application.Services
{
    public class InsuranceService(IInsuranceRepository insuranceRepository, IMapper mapper)
        : GenericService<InsuranceEntity>(insuranceRepository, mapper), IInsuranceService
    {
    }
}
