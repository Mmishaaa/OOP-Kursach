namespace ScooterBooking.Domain.Entities
{
    public class BookingEntity : BaseEntity
    {
        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }
        public decimal TotalPrice { get; set; }

        public Guid UserId { get; set; }
        public UserEntity? User { get; set; }
        public Guid ScooterId { get; set; }
        public ScooterEntity? Scooter { get; set; }
    }
}
