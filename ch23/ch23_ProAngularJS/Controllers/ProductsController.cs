using SportsStore.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Net;
using System.Net.Http;
using System;
using Newtonsoft.Json;
using System.Linq;

namespace SportsStore.Controllers
{
    [Route("products")]
    public class ProductsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return Repository.Products;
        }

        [HttpGet]
        [Route("products/{id:int}")]
        public Product GetProduct(int id)
        {
            return Repository.Products.SingleOrDefault(p => p.Id == id);
        }


        [HttpPost]
        public Product PostProduct([FromBody] Product product)
        {
            product.Id = Repository.Products.Max(p => p.Id) + 1;
            Repository.Products.Add(product);
            return product;
        }

        [Route("products/{id}")]
        [HttpPut]
        public Product PutProduct([FromBody] Product product, int id)
        {
            Product newProduct = Repository.Products.Find(p => p.Id == product.Id);
            newProduct.Price = product.Price;
            newProduct.Category = product.Category;
            newProduct.Name = product.Name;
            return newProduct;
        }

        [Route("products/{id}")]
        [HttpDelete]
        public Product DeleteProduct(int id)
        {
            Product product = Repository.Products.Find(p => p.Id == id);
            if (product != null)
            {
                Repository.Products.Remove(product);
            }

            return product;
        }

    }
}
