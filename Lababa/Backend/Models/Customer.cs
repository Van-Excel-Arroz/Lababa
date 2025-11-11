using System;

namespace Lababa.Backend.Models
{
    public class Customer : IEntity
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
