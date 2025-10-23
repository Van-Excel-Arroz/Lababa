namespace Lababa.Backend.Models
{
    public enum OrderStatus
    {
        Ready,
        Pending,
        InProgress,
        Completed,
        Cancelled
    }

    public enum PaymentStatus
    {
        Paid,
        Unpaid,
        Partial,
        Refunded
    }
}
