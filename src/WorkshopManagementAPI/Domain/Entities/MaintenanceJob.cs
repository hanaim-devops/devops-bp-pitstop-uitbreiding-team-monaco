using Pitstop.MaintenanceHistoryAPI.Model;

namespace Pitstop.WorkshopManagementAPI.Domain.Entities;

public class MaintenanceJob : Entity<Guid>
{
    public Timeslot PlannedTimeslot { get; private set; }
    public Vehicle Vehicle { get; private set; }
    public Customer Customer { get; private set; }
    public string Description { get; private set; }
    public Timeslot ActualTimeslot { get; private set; }
    public string Notes { get; private set; }
    public string Status => (ActualTimeslot == null) ? "Planned" : "Completed";
    
    public List<UsedPart> UsedParts { get; private set; } = new List<UsedPart>();

    public MaintenanceJob(Guid id) : base(id)
    {

    }

    public void Plan(Timeslot timeslot, Vehicle vehicle, Customer customer, string description)
    {
        PlannedTimeslot = timeslot;
        Vehicle = vehicle;
        Customer = customer;
        Description = description;
    }

    public void Finish(Timeslot actualTimeslot, string notes)
    {

        ActualTimeslot = actualTimeslot;
        Notes = notes;
    }

    public void AddUsedPart(RepairPart repairPart)
    {
        // Check if repair part is in stock
        if (repairPart.Quantity == 0)
        {
            throw new InvalidOperationException("Cannot use a repair part with quantity 0");
        }
        
        Guid repairPartId = repairPart.Id;
        UsedPart partAlreadyUsed = UsedParts.FirstOrDefault(up => up.RepairPartId == repairPartId);
        
        // If the part is not yet used, add it (default used quantity is 1)
        if (partAlreadyUsed == null)
        {
            UsedParts.Add(new UsedPart()
            {
                RepairPartId = repairPartId,
                MaintenanceJobId = this.Id,
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