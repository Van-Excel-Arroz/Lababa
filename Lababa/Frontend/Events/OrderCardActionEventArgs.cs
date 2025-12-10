using Lababa.Backend.Models;

namespace Lababa.Frontend.Events
{
    public enum OrderCardActionType 
    {
        Update,
        Delete
    }


    public class OrderCardActionEventArgs : EventArgs
    {
        public Order Order { get;  }
        public OrderCardActionType Action { get; }

        public OrderCardActionEventArgs(Order order, OrderCardActionType action)
        {
            Order = order;
            Action = action;
        }
    }
}
