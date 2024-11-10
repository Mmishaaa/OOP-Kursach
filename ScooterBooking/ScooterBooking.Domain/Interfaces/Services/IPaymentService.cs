using ScooterBooking.Domain.Entities;

namespace ScooterBooking.Domain.Interfaces.Services
{
    public interface IPaymentService : IGenericService<PaymentEntity>
    {
        Task<PaymentEntity> UpdateAsync(Guid id, PaymentEntity model, decimal enteredPrice, CancellationToken cancellationToken);
    }
}
