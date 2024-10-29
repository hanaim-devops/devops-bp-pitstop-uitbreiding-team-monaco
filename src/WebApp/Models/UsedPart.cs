namespace Pitstop.WebApp.Models;

public class UsedPart
{
    public int Id { get; set; }
    public int UsedQuantity { get; set; } = 1;

    public int RepairPartId { get; set; }
    
    public RepairPart RepairPart { get; set; }
    
    public int MaintenanceHistoryId { get; set; }
    
    public MaintenanceHistory MaintenanceHistory { get; set; }
}