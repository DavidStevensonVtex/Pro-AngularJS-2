﻿using SportsStore.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Net;
using System.Net.Http;
using System;
using Newtonsoft.Json;

namespace SportsStore.Controllers
{
    public class ProductsController : ApiController
    {
        [Route("products")]
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
    }
}
