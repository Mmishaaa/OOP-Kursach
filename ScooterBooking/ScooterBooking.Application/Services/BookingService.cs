using AutoMapper;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Interfaces.Repositories;
using ScooterBooking.Domain.Interfaces.Services;

namespace ScooterBooking.Application.Services
{
    public class BookingService(IBookingRepository bookingRepository, IMapper mapper)
        : GenericService<BookingEntity>(bookingRepository, mapper), IBookingService
    {
    }
}
