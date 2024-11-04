using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Domain.Entities
{
    public class ScooterEntity : BaseEntity
    {
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public ScooterStatus Status { get; set; }

        public Guid InsuranceId { get; set; }
        public InsuranceEntity? Insurance { get; set; }
        public Guid LocationId { get; set; }
        public LocationEntity? Location { get; set; }
    }
}
