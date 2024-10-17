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
    public List<UsedParts> UsedParts { get; set; }
}

