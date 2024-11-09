using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Repositories;

namespace ScooterBooking.Infrastructure.Repositories
{
    public class BookingRepository(ApplicationDbContext context) : GenericRepository<BookingEntity>(context), IBookingRepository
    {
    }
}
