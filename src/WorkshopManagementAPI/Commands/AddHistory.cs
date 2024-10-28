namespace Pitstop.WorkshopManagementAPI.Commands;

public class AddHistory
{
    public string LicenseNumber { get; set; }
    public DateTime MaintenanceDate { get; set; }
    public string Description { get; set; }
    public Guid MaintenanceJobId { get; set; }
}