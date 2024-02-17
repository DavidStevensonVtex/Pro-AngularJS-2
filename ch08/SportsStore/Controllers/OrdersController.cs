using SportsStore.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SportsStore.Controllers
{
    public class OrdersController : ApiController
    {
        [Route("orders")]
        [HttpGet]
        public IEnumerable<Order> GetOrders()
        {
            return OrderRepository.Orders;
        }

        [Route("orders")]
        [HttpPost]
        public Order PostOrder(Order order)
        {
            order.OrderId = OrderRepository.Orders.Count == 0 ? 123 : OrderRepository.Orders.Max(o => o.OrderId) + 1;
            OrderRepository.Orders.Add(order);
            return order;
        }
    }
}
