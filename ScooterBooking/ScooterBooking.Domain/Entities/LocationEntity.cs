namespace ScooterBooking.Domain.Entities
{
    public class LocationEntity : BaseEntity
    {
        public string City { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public int BuildingNumber  { get; set; }

        public List<ScooterEntity> Scooters { get; set; } = [];
    }
}
