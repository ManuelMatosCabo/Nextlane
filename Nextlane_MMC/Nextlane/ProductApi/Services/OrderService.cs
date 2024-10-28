using ProductApi.Data;
using ProductApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ProductApi.Services
{
    public class OrderService
    {
        private readonly ApplicationContext _context;

        public OrderService(ApplicationContext context)
        {
            _context = context;
        }

        public List<Order> GetOrdersByCustomerId(int customerId)
        {
            // Retrieve orders from the database using Entity Framework
            var customer = _context.Customers
                .Include(c => c.Orders) // Include orders in the query
                .FirstOrDefault(c => c.CustomerId == customerId);

            // Return the customer's orders, or an empty list if not found
            return customer?.Orders ?? new List<Order>();
        }
    }
}
