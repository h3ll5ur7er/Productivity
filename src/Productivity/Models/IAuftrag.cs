namespace Productivity.Models
{
    public interface IAuftrag
    {
        int Id { get; set; }
        int KW { get; set; }
        double Produktivitaet { get; set; }
        double Wirtschaftlichkeit { get; set; }
        double FaktorZugang { get; set; }
        double FaktorSystem { get; set; }
        double FaktorMontageArt { get; set; }
        double FaktorStockwerk { get; set; }
        int EmployeeId { get; set; }
        Employee Employee { get; set; }
    }
}