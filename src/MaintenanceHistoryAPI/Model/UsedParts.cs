using Pitstop.WorkshopManagementAPI.Domain.Entities;

namespace Pitstop.MaintenanceHistoryAPI.Model;

public class UsedParts
{
    public Guid Id { get; set; }
    
    public Guid MaintenanceJobId { get; set; }
    
    public MaintenanceJob MaintenanceJob { get; set; }
}