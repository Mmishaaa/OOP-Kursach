using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Repositories;

namespace ScooterBooking.Infrastructure.Repositories
{
    public class PricingRepository(ApplicationDbContext context) : GenericRepository<PricingEntity>(context), IPricingRepository
    {
    }
}
