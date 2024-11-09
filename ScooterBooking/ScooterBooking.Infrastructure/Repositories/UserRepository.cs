using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Repositories;

namespace ScooterBooking.Infrastructure.Repositories
{
    public class UserRepository(ApplicationDbContext context) : GenericRepository<UserEntity>(context), IUserRepository
    {
    }
}
