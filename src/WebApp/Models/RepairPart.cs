namespace Pitstop.WebApp.Models;

public class RepairPart
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public int WarrantyPeriod { get; set; }
}