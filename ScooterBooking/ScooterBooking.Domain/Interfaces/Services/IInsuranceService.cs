using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.PaginationModels;

namespace ScooterBooking.Domain.Interfaces.Services
{
    public interface IInsuranceService : IGenericService<InsuranceEntity>
    {
        Task<InsuranceEntity> AddAsync(InsuranceEntity insuranceEntity, CancellationToken cancellationToken);
        Task<InsuranceEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken);
        Task<PagedResult<InsuranceEntity>> GetAllAsync(int pageNumber, int pageSize, CancellationToken cancellationToken);
        Task<InsuranceEntity> UpdateAsync(Guid id, InsuranceEntity insuranceEntity, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }
}
