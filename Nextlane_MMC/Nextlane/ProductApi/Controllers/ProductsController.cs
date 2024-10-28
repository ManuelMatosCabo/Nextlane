using Microsoft.AspNetCore.Mvc;
using ProductApi.Services;

namespace ProductApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly OrderService _orderService;

        public OrdersController(OrderService orderService)
        {
            _orderService = orderService;
        }

        // GET: api/orders/customer/1
        [HttpGet("customer/{customerId}")]
        public IActionResult GetOrdersByCustomerId(int customerId)
        {
            var orders = _orderService.GetOrdersByCustomerId(customerId);
            if (orders.Count == 0)
            {
                return NotFound($"No orders found for customer with ID = {customerId}");
            }
            return Ok(orders);
        }
    }
}
