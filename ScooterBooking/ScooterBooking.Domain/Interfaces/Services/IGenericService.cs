using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.PaginationModels;

namespace ScooterBooking.Domain.Interfaces.Services
{
    public interface IGenericService<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> AddAsync(TEntity bookingEntity, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
        Task<PagedResult<TEntity>> GetAllAsync(int pageNumber, int pageSize, CancellationToken cancellationToken);
        Task<TEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken);
        Task<TEntity> UpdateAsync(Guid id, TEntity model, CancellationToken cancellationToken);
    }
}
