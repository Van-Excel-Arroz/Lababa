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
        Refunded
    }

    public enum PricingMethod
    {
        Weight,
        Item,
        Hybrid
    }

    public enum WeightUnit
    {
        Kilograms,
        Pounds
    }
}
