using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces;

namespace ScooterBooking.Infrastructure.Repositories
{
    public class UserRepository(ApplicationDbContext context) : GenericRepository<UserEntity>(context), IUserRepository
    {
    }
}
