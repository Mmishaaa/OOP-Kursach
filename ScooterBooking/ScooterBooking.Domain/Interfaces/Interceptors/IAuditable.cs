namespace ScooterBooking.Domain.Interfaces.Interceptors
{
    public interface IAuditable
    {
        DateTime CreatedAt { get; set; }
    }
}
