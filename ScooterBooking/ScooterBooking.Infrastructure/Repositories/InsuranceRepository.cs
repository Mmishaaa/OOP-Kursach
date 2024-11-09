using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Repositories;

namespace ScooterBooking.Infrastructure.Repositories
{
    public class InsuranceRepository(ApplicationDbContext context) : GenericRepository<InsuranceEntity>(context), IInsuranceRepository
    {
    }
}
