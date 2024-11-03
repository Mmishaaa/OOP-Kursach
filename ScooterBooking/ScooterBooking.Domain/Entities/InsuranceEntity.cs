using ScooterBooking.Domain.Enums;

namespace ScooterBooking.Domain.Entities
{
    public class InsuranceEntity : BaseEntity
    {
        public InsuranceType Type { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Cost { get; set; }

        public List<ScooterEntity> Scooters = [];
    }
}
