using System.Collections.Generic;

namespace SportsStore.Models
{
    public static class OrderRepository
    {
        public static List<Order> Orders { get; set; } = new List<Order>();
    }
}