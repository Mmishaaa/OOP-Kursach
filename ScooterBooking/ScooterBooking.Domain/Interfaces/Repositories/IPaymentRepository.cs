using ScooterBooking.Domain.Entities;

namespace ScooterBooking.Domain.Interfaces.Repositories
{
    public interface IPaymentRepository : IGenericRepository<PaymentEntity>
    {
        Task<PaymentEntity?> GetPlaneEntityByIdAsync(Guid id, CancellationToken cancellationToken);
    }
}
