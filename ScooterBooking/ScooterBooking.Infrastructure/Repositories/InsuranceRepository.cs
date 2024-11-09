using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces;

namespace ScooterBooking.Infrastructure.Repositories
{
    public class InsuranceRepository(ApplicationDbContext context) : GenericRepository<InsuranceEntity>(context), IInsuranceRepository
    {
    }
}
