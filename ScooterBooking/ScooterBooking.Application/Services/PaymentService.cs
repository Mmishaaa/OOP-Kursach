using AutoMapper;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Repositories;
using ScooterBooking.Domain.Interfaces.Services;

namespace ScooterBooking.Application.Services
{
    public class PaymentService(IGenericRepository<PaymentEntity> genericRepository, IMapper mapper) 
        : GenericService<PaymentEntity>(genericRepository, mapper), IPaymentService
    {
    }
}
