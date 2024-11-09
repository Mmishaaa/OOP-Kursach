using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Repositories;

namespace ScooterBooking.Infrastructure.Repositories
{
    public class ReviewRepository(ApplicationDbContext context) : GenericRepository<ReviewEntity>(context), IReviewRepository
    {
    }
}
