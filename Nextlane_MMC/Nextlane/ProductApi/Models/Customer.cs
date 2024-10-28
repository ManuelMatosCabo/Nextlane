using System.Collections.Generic;

namespace ProductApi.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; } = string.Empty;  // Ensure non-null value

        public List<Order> Orders { get; set; } = new List<Order>();  // Ensure non-null value
    }
}
