using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces;

namespace ScooterBooking.Infrastructure.Repositories
{
    public class PaymentRepository(ApplicationDbContext context) : GenericRepository<PaymentEntity>(context), IPaymentRepository
    {
    }
}
