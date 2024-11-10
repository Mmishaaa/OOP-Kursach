using AutoMapper;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Enums;
using ScooterBooking.Domain.Interfaces.Repositories;
using ScooterBooking.Domain.Interfaces.Services;

namespace ScooterBooking.Application.Services
{
    public class BookingService(
        IBookingRepository bookingRepository,
        IMapper mapper,
        IPricingRepository pricingRepository,
        IPaymentRepository paymentRepository)
        : GenericService<BookingEntity>(bookingRepository, mapper), IBookingService
    {
        public override async Task<BookingEntity> AddAsync(BookingEntity bookingEntity, CancellationToken cancellationToken)
        {
            var pricingEntity = await pricingRepository.GetByScooterIdAsync(bookingEntity.ScooterId, cancellationToken);

            var hours = (decimal)(bookingEntity.EndsAt - bookingEntity.StartsAt).TotalHours;

            bookingEntity.TotalPrice = pricingEntity.SpeedPriceHour * hours;
            
            var entity = await _genericRepository.AddAsync(bookingEntity, cancellationToken);

            var paymentEntity = new PaymentEntity()
            {
                BookingId = bookingEntity.Id,
                Method = PaymentMethod.NoneSpecified,
                Status = PaymentStatus.Pending,
            };

            await paymentRepository.AddAsync(paymentEntity, cancellationToken);

            return _mapper.Map<BookingEntity>(entity);
        }
    }
}
