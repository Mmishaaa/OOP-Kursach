using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.PaginationModels;

namespace ScooterBooking.Domain.Interfaces.Services
{
    public interface IBookingService
    {
        Task<BookingEntity> AddAsync(BookingEntity model, CancellationToken cancellationToken);
        Task<BookingEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken);
        Task<PagedResult<BookingEntity>> GetAllAsync(int pageNumber, int pageSize, CancellationToken cancellationToken);
        Task<BookingEntity> UpdateAsync(Guid id, BookingEntity model, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    }
}
