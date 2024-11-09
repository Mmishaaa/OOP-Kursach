namespace ScooterBooking.Domain.Entities
{
    public class PricingEntity : BaseEntity
    {
        public decimal SpeedPriceHour { get; set; }
        public int MaxSpeed { get; set; }

        public Guid ScooterId { get; set; }
        public ScooterEntity? Scooter { get; set; }
    }
}
