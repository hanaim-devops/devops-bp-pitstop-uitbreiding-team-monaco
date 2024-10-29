using System.ComponentModel;

namespace Pitstop.MaintenanceHistoryAPI.Model;

public class MaintenanceHistory
{
    public int Id { get; set; }
    public string LicenseNumber { get; set; }
    public DateTime MaintenanceDate { get; set; }
    public string? Description { get; set; }  
    public MaintenanceTypes MaintenanceType { get; set; }
    public Guid MaintenanceJobId { get; set; }
    [DefaultValue("false")]
    public bool IsCompleted { get; set; }
    public List<UsedPart> UsedParts { get; set; }
    
    public void AddUsedPart(RepairPart repairPart)
    {
        // Check if repair part is in stock
        if (repairPart.Quantity == 0)
        {
            throw new InvalidOperationException("Cannot use a repair part with quantity 0");
        }
        
        int repairPartId = repairPart.Id;
        UsedPart partAlreadyUsed = UsedParts.FirstOrDefault(up => up.RepairPartId == repairPartId);
        
        // If the part is not yet used, add it (default used quantity is 1)
        if (partAlreadyUsed == null)
        {
            UsedParts.Add(new UsedPart()
            {
                RepairPartId = repairPartId,
                MaintenanceHistoryId = this.Id,
                UsedQuantity = 1
            });
        }
        // If the part is already used, increase the quantity
        else
        {
            partAlreadyUsed.UsedQuantity++;
        }
        
        // Reduce quantity of repair part
        repairPart.Quantity--;
    }
}

