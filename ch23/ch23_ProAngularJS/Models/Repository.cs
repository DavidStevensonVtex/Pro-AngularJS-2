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
            new Product (1, "Apples", "Fruit", 1.20m ),
            new Product (2, "Bananas", "Fruit", 2.42m ),
            new Product (3, "Pears", "Fruit", 2.02m ),
            new Product (4, "Tuna", "Fish", 20.45m ),
            new Product (5, "Salmon", "Fish", 17.93m ),
            new Product (6, "Trout", "Fish", 12.93m )
        };

        public static List<Product> Products
        {
            get { return products; }
        }
    }
}