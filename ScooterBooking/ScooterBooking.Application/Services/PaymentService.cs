using AutoMapper;
using ScooterBooking.Domain.Entities;
using ScooterBooking.Domain.Enums;
using ScooterBooking.Domain.Exceptions;
using ScooterBooking.Domain.Interfaces.Repositories;
using ScooterBooking.Domain.Interfaces.Services;

namespace ScooterBooking.Application.Services
{
    public class PaymentService(IPaymentRepository paymentRepository, IMapper mapper, IBookingRepository bookingRepository) 
        : GenericService<PaymentEntity>(paymentRepository, mapper), IPaymentService
    {
        public async Task<PaymentEntity> UpdateAsync(Guid id, PaymentEntity paymentEntity, decimal enteredPrice, CancellationToken cancellationToken)
        {
            var bookingEntity = await bookingRepository.GetByIdAsync(paymentEntity.BookingId, cancellationToken);

            if (bookingEntity is not null)
            {
                if (enteredPrice < bookingEntity.TotalPrice)
                {
                    paymentEntity.Id = id;
                    paymentEntity.Status = PaymentStatus.Failed;
                    await paymentRepository.UpdateAsync(paymentEntity, cancellationToken);
                    throw new BadRequestException("Insufficient funds");
                }

                if (enteredPrice >= bookingEntity.TotalPrice)
                {
                    paymentEntity.Id = id;
                    paymentEntity.Status = PaymentStatus.Completed;
                    var updatedStatus = await paymentRepository.UpdateAsync(paymentEntity, cancellationToken);
                    return updatedStatus;
                }
            }

            var currentPayment = await paymentRepository.GetPlaneEntityByIdAsync(id, cancellationToken);
            if (currentPayment is not null)
            {
                currentPayment.Status = PaymentStatus.Canceled;
                await paymentRepository.UpdateAsync(currentPayment, cancellationToken);
            }

            throw new NotFoundException($"Booking with id: {paymentEntity.BookingId} was not found");
        }
    }
}
