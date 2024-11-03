namespace ScooterBooking.Domain.Enums
{
    public enum PaymentStatus
    {
        None = 0,
        Pending,
        Completed,
        Failed,
        Refunded,
        Canceled
    }
}
