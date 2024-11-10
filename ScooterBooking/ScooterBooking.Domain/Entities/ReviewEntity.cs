using ScooterBooking.Domain.Enums;
using ScooterBooking.Domain.Interfaces.Interceptors;

namespace ScooterBooking.Domain.Entities
{
    public class ReviewEntity : BaseEntity, IAuditable
    {
        public Rating Rating { get; set; }
        public string Text { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }

        public Guid UserId { get; set; }
        public UserEntity? User { get; set; }
        public Guid BookingId { get; set; }
        public BookingEntity? Booking { get; set; }
    }
}
