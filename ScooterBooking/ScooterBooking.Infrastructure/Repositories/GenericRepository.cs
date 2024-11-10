using Microsoft.EntityFrameworkCore;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Repositories;
using ScooterBooking.Domain.PaginationModels;

namespace ScooterBooking.Infrastructure.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly ApplicationDbContext _context;
        protected DbSet<TEntity> _dbSet;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public virtual async Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken)
        {
            await _dbSet.AddAsync(entity, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return entity;
        }

        public virtual Task DeleteAsync(TEntity entity, CancellationToken cancellationToken)
        {
            _dbSet.Remove(entity);
            return _context.SaveChangesAsync(cancellationToken);
        }

        public virtual Task<PagedResult<TEntity>> GetAllAsync(int pageNumber, int pageSize, CancellationToken cancellationToken)
        {
            var query = _dbSet.AsNoTracking();
            var pagedResult =  GetPagedResultAsync(query, pageNumber, pageSize);
            return pagedResult;
        }

        public virtual Task<TEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var entity = _dbSet.AsNoTracking().FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
            return entity;
        }

        public virtual async Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity;
        }
        protected Task<PagedResult<TEntity>> GetPagedResultAsync(IQueryable<TEntity> query, int pageNumber, int pageSize)
        {
            var totalCount = query.Count();
            var data = query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return Task.FromResult(new PagedResult<TEntity>
            {
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalCount = totalCount,
                TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize),
                Data = data
            });
        }
    }
}
