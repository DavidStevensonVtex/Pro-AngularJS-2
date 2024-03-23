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
            //throw new Exception("Failed to get data from repository.");
            //throw new HttpResponseException(
            //    new HttpResponseMessage(HttpStatusCode.BadRequest) {
            //        ReasonPhrase = "An error occurred getting data from the respository."
            //    });
            return Repository.Products;
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
