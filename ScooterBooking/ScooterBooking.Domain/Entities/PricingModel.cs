namespace ScooterBooking.Domain.Entities
{
    public class PricingModel : BaseEntity
    {
        public decimal SpeedPriceHour { get; set; }
        public int MaxSpeed { get; set; }

        public Guid ScooterId { get; set; }
        public ScooterEntity Scooter { get; set; } = new();
    }
}
