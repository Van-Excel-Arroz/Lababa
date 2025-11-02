using System;

namespace Lababa.Backend.Models
{
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
