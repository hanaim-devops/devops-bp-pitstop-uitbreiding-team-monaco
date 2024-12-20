using System.ComponentModel.DataAnnotations;

namespace Pitstop.MaintenanceHistoryAPI.Model;

public class RepairPart
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    [DataType(DataType.Currency)]
    public decimal Price { get; set; }
    public int WarrantyPeriod { get; set; }
}