using Newtonsoft.Json;
using System.Collections.Generic;

namespace SportsStore.Models
{
    public class OrderItem
    {
        [JsonProperty("id")]
        public int ProductId { get; set; }

        [JsonProperty("count")]
        public int Quantity { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Order
    {
        [JsonProperty("id")]
        public int OrderId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string ZipCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("giftwrap")]
        public bool GiftWrap { get; set; }

        [JsonProperty("products")]
        public List<OrderItem> Products { get; set; }

    }
}