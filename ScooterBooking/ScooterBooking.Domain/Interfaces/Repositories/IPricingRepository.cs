using ScooterBooking.Domain.Entities;

namespace ScooterBooking.Domain.Interfaces.Repositories
{
    public interface IPricingRepository : IGenericRepository<PricingEntity>
    {
        Task<PricingEntity> GetByScooterIdAsync(Guid scooterId, CancellationToken cancellationToken);
    }
}
