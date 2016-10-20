using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Productivity.Data;
using Productivity.Models;

namespace Productivity.Controllers
{
    [Route("[controller]")]
    public class ProductivityController : Controller
    {
        private readonly Personen personen;

        public ProductivityController(Personen personen)
        {
            this.personen = personen;
        }

        // GET api/values
        [HttpGet]
        public ViewResult Get()
        {
            return View("List", personen);
        }

        // GET api/values/5
        [HttpGet("{name}")]
        public string Get(string name)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        protected override void Dispose(bool disposing)
        {
            personen.Dispose();
            base.Dispose(disposing);
        }
    }
}