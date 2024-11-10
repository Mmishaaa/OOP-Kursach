using Microsoft.EntityFrameworkCore;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Repositories;

namespace ScooterBooking.Infrastructure.Repositories
{
    public class PricingRepository(ApplicationDbContext context) : GenericRepository<PricingEntity>(context), IPricingRepository
    {
        public Task<PricingEntity> GetByScooterIdAsync(Guid scooterId, CancellationToken cancellationToken)
        {
            var entity = _dbSet.AsNoTracking().FirstOrDefaultAsync(e => e.ScooterId == scooterId, cancellationToken);
            return entity;
        }
    }
}
