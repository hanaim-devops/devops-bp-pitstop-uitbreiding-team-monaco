using System.ComponentModel.DataAnnotations;

namespace Pitstop.MaintenanceHistoryAPI.Model;

public class RepairPart
{
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}