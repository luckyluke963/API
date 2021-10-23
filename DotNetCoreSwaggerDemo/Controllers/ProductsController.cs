using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreSwaggerDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet("GetResponse")]
        public ActionResult GetResponse()
        {
            return Ok("Return Success");
        }

        [HttpGet("GetAll")]
        public IEnumerable<Product> GetAllProduct()
        {
            var prodList = new List<Product>()
            {
                new Product(){ProductId=1,ProductName="Computer",Price=50000},
                 new Product(){ProductId=2,ProductName="mouse",Price=500},
                  new Product(){ProductId=3,ProductName="keyboard",Price=200}
            };
            return prodList;
        }

        [HttpPost("Post")]
        public IEnumerable<Product> SaveProduct(Product odj)
        {
            var prodList = new List<Product>()
            {
                new Product(){ProductId=1,ProductName="Computer",Price=50000},
                 new Product(){ProductId=2,ProductName="mouse",Price=500},
                  new Product(){ProductId=3,ProductName="keyboard",Price=200}
            };
            prodList.Add(odj);
            return prodList;
        }
        [HttpPut("Post")]
        public void Put(int ProductId, [FromBody] String ProductName)
        {

        }
        [HttpDelete("Post")]
        public void Delete(int ProductId)
        {

        }


        public class Product
        {
            public int ProductId { get; set; }

            public String ProductName { get; set; }
            public decimal Price { get; set; }

        }
    }
}
