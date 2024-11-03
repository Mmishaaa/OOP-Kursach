using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Domain.Entities
{
    public class ReviewEntity : BaseEntity
    {
        public Rating Rating { get; set; }
        public string Text { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }

        public Guid UserId { get; set; }
        public UserEntity User { get; set; } = new();
        public Guid BookingId { get; set; }
        public BookingEntity Booking { get; set; } = new();
    }
}
