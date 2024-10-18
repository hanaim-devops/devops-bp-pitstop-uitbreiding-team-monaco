using System.ComponentModel.DataAnnotations;
using Pitstop.WorkshopManagementAPI.Domain.Entities;

namespace Pitstop.MaintenanceHistoryAPI.Model;

public class UsedPart
{
    [Key]
    public Guid Id { get; set; }
    
    public int UsedQuantity { get; set; } = 1;

    public Guid RepairPartId { get; set; }
    
    public RepairPart RepairPart { get; set; }
    
    public Guid MaintenanceJobId { get; set; }
    
    public MaintenanceJob MaintenanceJob { get; set; }
}