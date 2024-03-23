using Newtonsoft.Json;

namespace SportsStore.Models
{
    public class Product
    {
        public Product(int id, string name, string category, decimal price)
        {
            this.Id = id;
            this.Name = name;
            this.Category = category;
            this.Price = price;
        }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }
    }
}