using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Data;
using System.Collections.Generic;

namespace Api
{
    public static class Functions
    {
        [FunctionName("Product")]
        public static IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req, ILogger log)
        {
            var products = new List<Product>
    {
        new Product
        {
            Name = "Book",
            Description = "A great book",
            Price = 9.99m
        },
        new Product
        {
            Name = "Phone",
            Description = "A good phone",
            Price = 149.99m
        },
        new Product
        {
            Name = "Car",
            Description = "A bad car ",
            Price = 999.99m
        }
    };

            return new OkObjectResult(products);
        }
    }
}
