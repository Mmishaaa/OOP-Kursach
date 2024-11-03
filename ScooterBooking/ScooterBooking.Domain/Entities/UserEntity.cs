namespace ScooterBooking.Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int PhoneNumber { get; set; }

        public List<BookingEntity> Bookings { get; set; } = [];
    }
}
