using System.Text.Json.Serialization;

namespace ProductApi.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Product { get; set; } = string.Empty;  // Ensure non-null value for Product name
        public decimal Price { get; set; }

        public int CustomerId { get; set; }

        [JsonIgnore]  // Prevents circular reference when serializing
        public Customer? Customer { get; set; }
    }
}
