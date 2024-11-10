using Microsoft.EntityFrameworkCore;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Repositories;
using ScooterBooking.Domain.PaginationModels;

namespace ScooterBooking.Infrastructure.Repositories
{
    public class PaymentRepository(ApplicationDbContext context) : GenericRepository<PaymentEntity>(context), IPaymentRepository
    {
        public override Task<PaymentEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var payment = _dbSet
                .AsNoTracking()
                .Include(p => p.Booking)
                .FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
            
            return payment;
        }

        public override Task<PagedResult<PaymentEntity>> GetAllAsync(int pageNumber, int pageSize, CancellationToken cancellationToken)
        {
            var query = _dbSet
                .AsNoTracking()
                .Include(p => p.Booking);

            var pagedResult = GetPagedResultAsync(query, pageNumber, pageSize);
            return pagedResult;
        }

        public Task<PaymentEntity?> GetPlaneEntityByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var payment = _dbSet
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id == id, cancellationToken);

            return payment;
        }
    }
}
