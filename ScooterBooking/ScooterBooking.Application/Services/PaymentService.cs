using AutoMapper;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Repositories;
using ScooterBooking.Domain.Interfaces.Services;

namespace ScooterBooking.Application.Services
{
    public class PaymentService(IPaymentRepository paymentRepository, IMapper mapper) 
        : GenericService<PaymentEntity>(paymentRepository, mapper), IPaymentService
    {
    }
}
