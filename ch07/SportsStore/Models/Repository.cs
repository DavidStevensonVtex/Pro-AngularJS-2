using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsStore.Models
{
    public class Repository
    {
        private static List<Product> products { get; set; } = new List<Product>()
        {
            new Product ( 1, "Kayak", "A boat for one person", "Watersports", 275m ),
            new Product ( 2, "Lifejacket", "Protective and fashionable", "Watersports", 48.95m ),
            new Product ( 3, "Soccer Ball", "FIFA-approved size and weight", "Soccer", 19.5m),
            new Product ( 4, "Corner Flags", "Give our playing field a professional touch", "Soccer", 34.95m),
            new Product ( 5, "Stadium", "Flat-packed 35,000 seat stadium", "Soccer", 79500.00m),
            new Product ( 6, "Thinking Cap", "Improve your brain efficiency by 75%", "Chess", 16m),
            new Product ( 7, "Unsteady Chair", "Secretly give your opponent a disadvantage", "Chess", 29.95m),
            new Product ( 8, "Human Chess Board", "A fun game for the family", "Chess", 75),
            new Product ( 9, "Bling-Bling King", "Gold-plated, diamond-studded King", "Chess", 1200m)
        };

        public static IEnumerable<Product> Products
        {
            get { return products; }
        }
    }
}