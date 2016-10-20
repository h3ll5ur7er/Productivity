using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Productivity.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Umbau> Umbau { get; set; }
        public List<Neubau> Neubau { get; set; }
    }
}
