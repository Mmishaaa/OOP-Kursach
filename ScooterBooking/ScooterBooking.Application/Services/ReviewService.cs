using AutoMapper;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Repositories;
using ScooterBooking.Domain.Interfaces.Services;

namespace ScooterBooking.Application.Services
{
    public class ReviewService(IGenericRepository<ReviewEntity> genericRepository, IMapper mapper) : 
        GenericService<ReviewEntity>(genericRepository, mapper), IReviewService
    {
    }
}
