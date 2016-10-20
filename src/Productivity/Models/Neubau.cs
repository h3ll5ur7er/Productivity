using System;

namespace Productivity.Models
{
    public class Neubau : IAuftrag
    {
        public int Id { get; set; }

        public int KW { get; set; }

        public double Produktivitaet { get; set; }
        public double Wirtschaftlichkeit { get; set; }
        public double FaktorZugang { get; set; }
        public double FaktorSystem { get; set; }
        public double FaktorMontageArt { get; set; }
        public double FaktorStockwerk { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}