using AutoMapper;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Exceptions;
using ScooterBooking.Domain.Interfaces.Repositories;
using ScooterBooking.Domain.Interfaces.Services;
using ScooterBooking.Domain.PaginationModels;

namespace ScooterBooking.Application.Services
{
    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : BaseEntity
    {
        protected IGenericRepository<TEntity> _genericRepository;
        protected IMapper _mapper;

        public GenericService(IGenericRepository<TEntity> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }
        public virtual async Task<TEntity> AddAsync(TEntity bookingEntity, CancellationToken cancellationToken)
        {
            var modelToCreate = _mapper.Map<TEntity>(bookingEntity);
            var entity = await _genericRepository.AddAsync(modelToCreate, cancellationToken);
            return _mapper.Map<TEntity>(entity);
        }

        public virtual async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            var modelToDelete = await _genericRepository.GetByIdAsync(id, cancellationToken);
            if (modelToDelete is not null)
            {
                await _genericRepository.DeleteAsync(modelToDelete, cancellationToken);
            }
        }

        public virtual Task<PagedResult<TEntity>> GetAllAsync(int pageNumber, int pageSize, CancellationToken cancellationToken)
        {
            var pagedEntities = _genericRepository.GetAllAsync(pageNumber, pageSize, cancellationToken);
            return _mapper.Map<Task<PagedResult<TEntity>>>(pagedEntities);
        }

        public virtual Task<TEntity> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var entity = _genericRepository.GetByIdAsync(id, cancellationToken);
            return _mapper.Map<Task<TEntity>>(entity);
        }

        public virtual async Task<TEntity> UpdateAsync(Guid id, TEntity model, CancellationToken cancellationToken)
        {
            _ = await _genericRepository.GetByIdAsync(id, cancellationToken) ?? throw new NotFoundException("Entity with this id doesn't exist");
            var newEntity = _mapper.Map<TEntity>(model);
            newEntity.Id = id;
            await _genericRepository.UpdateAsync(newEntity, cancellationToken);
            return _mapper.Map<TEntity>(newEntity);
        }
    }
}
