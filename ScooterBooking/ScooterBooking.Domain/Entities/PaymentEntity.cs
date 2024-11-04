using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Domain.Entities
{
    public class PaymentEntity : BaseEntity
    {
        public PaymentMethod Method { get; set; }
        public PaymentStatus Status { get; set; }

        public Guid BookingId { get; set; }
        public BookingEntity? Booking { get; set; }
    }
}
