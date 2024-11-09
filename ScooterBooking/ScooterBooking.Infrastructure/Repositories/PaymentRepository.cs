using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Repositories;

namespace ScooterBooking.Infrastructure.Repositories
{
    public class PaymentRepository(ApplicationDbContext context) : GenericRepository<PaymentEntity>(context), IPaymentRepository
    {
    }
}
