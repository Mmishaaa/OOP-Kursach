using AutoMapper;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Repositories;
using ScooterBooking.Domain.Interfaces.Services;

namespace ScooterBooking.Application.Services
{
    public class BookingService(IGenericRepository<BookingEntity> genericRepository, IMapper mapper)
        : GenericService<BookingEntity>(genericRepository, mapper), IBookingService
    {
    }
}
