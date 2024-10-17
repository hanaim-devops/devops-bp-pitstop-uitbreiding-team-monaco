namespace Pitstop.MaintenanceHistoryAPI.Model;
using System.ComponentModel;

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
}

