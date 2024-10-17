namespace Pitstop.MaintenanceHistoryAPI.Model;

public class RepairParts
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}