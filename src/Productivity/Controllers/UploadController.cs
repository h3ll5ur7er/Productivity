using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Productivity.Data;
using Productivity.Models;

namespace Productivity.Controllers
{
    [Route("[controller]")]
    public class UploadController : Controller
    {
        private readonly Personen personen;
        private readonly Arbeit arbeit;

        public UploadController(Personen personen, Arbeit arbeit)
        {
            this.personen = personen;
            this.arbeit = arbeit;
        }

        // POST api/values
        [HttpPost("Employee")]
        public void Post([FromBody]Employee value)
        {
            personen.Add(ref value);
        }
        // POST api/values
        [HttpPost("Umbau")]
        public void Post([FromBody]Umbau value)
        {
            arbeit.AddGeneric(ref value);
        }
        // POST api/values
        [HttpPost("Neubau")]
        public void Post([FromBody]Neubau value)
        {
            arbeit.AddGeneric(ref value);
        }
    }
}
