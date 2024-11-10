using AutoMapper;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Repositories;
using ScooterBooking.Domain.Interfaces.Services;

namespace ScooterBooking.Application.Services
{
    public class ReviewService(IReviewRepository reviewRepository, IMapper mapper) : 
        GenericService<ReviewEntity>(reviewRepository, mapper), IReviewService
    {
    }
}
