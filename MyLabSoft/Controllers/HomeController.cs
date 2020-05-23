using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyLabSoft.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        // GET: api/Home
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            DataAccessLayer obj = new DataAccessLayer();
            var productlist = obj.GetProducts();

            return productlist;
        }

        // GET: api/Home/5
        [HttpGet("{id}", Name = "Get")]
        public IEnumerable<Product> Get(int id)
        {
            DataAccessLayer obj = new DataAccessLayer();
            var productlist = obj.GetProducts();
            var result = from word in productlist where word.ProductID ==id select word;
            return result;
        }

        // POST: api/Home
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Home/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
