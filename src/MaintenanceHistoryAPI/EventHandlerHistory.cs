using System.Diagnostics;
using Pitstop.MaintenanceHistoryAPI.Events;
using Serilog;

namespace Pitstop.MaintenanceHistoryAPI;

public class EventHandlerHistory(IMessageHandler messageHandler, MaintenanceHistoryContext maintenanceHistoryContext) : IHostedService, IMessageHandlerCallback
{
    public async Task StartAsync(CancellationToken cancellationToken)
    {
        var activitySource = new ActivitySource("Pitstop.MaintenanceHistoryAPI.EventHandlerHistory");
        messageHandler.Start(this, activitySource);
        
        Console.WriteLine("EventHandlerHistory started.");
        
        await Task.CompletedTask;
        
        Console.WriteLine("EventHandlerHistory started.");
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        messageHandler.Stop();
        return Task.CompletedTask;
    }

    public async Task<bool> HandleMessageAsync(string messageType, string message)
    {
        try
        {
            var messageObject = MessageSerializer.Deserialize(message);
            switch (messageType)
            {
                case "MaintenanceJobPlanned":
                    await HandleAsync(messageObject.ToObject<MaintenanceJobPlanned>());
                    break;
                case "MaintenanceJobFinished":
                    await HandleAsync(messageObject.ToObject<MaintenanceJobFinished>());
                    break;
            }
        }
        catch (Exception ex)
        {
            Log.Error(ex, $"Error while handling {messageType} event.");
        }

        return true;
    }

    private async Task<bool> HandleAsync(MaintenanceJobPlanned e)
    {
        Log.Information("Register Maintenance Job: {JobId}, {StartTime}, {EndTime}, {CustomerName}, {LicenseNumber}",
            e.JobId, e.StartTime, e.EndTime, e.CustomerInfo.Name, e.VehicleInfo.LicenseNumber);
        try
        {
            // insert maintenance history
            var history = new MaintenanceHistory()
            {
                LicenseNumber = e.VehicleInfo.LicenseNumber,
                MaintenanceDate = e.StartTime.Date,
                MaintenanceType = MaintenanceTypes.Overig,
                MaintenanceJobId = e.JobId,
            };
            await maintenanceHistoryContext.MaintenanceHistories.AddAsync(history);

            Log.Information(
                "Maintenance history added: {LicenseNumber}, {MaintenanceDate}, {MaintenanceType}, {MaintenanceJobId}, {Description}, {IsCompleted}",
                history.LicenseNumber, history.MaintenanceDate, history.MaintenanceType, history.MaintenanceJobId,
                history.Description, history.IsCompleted);

            await maintenanceHistoryContext.SaveChangesAsync();
        }
        catch (DbUpdateException)
        {
            Log.Warning("Skipped adding history job with id {JobId}.", e.JobId);
        }
        
        return true;
    }


    private async Task<bool> HandleAsync(MaintenanceJobFinished e)
    {
        Log.Information("Finish Maintenance job: {JobId}, {ActualStartTime}, {EndTime}",
            e.JobId, e.StartTime, e.EndTime);

        try
        {
            // insert maintenance history
            var maintenanceHistory = await maintenanceHistoryContext.MaintenanceHistories.FirstOrDefaultAsync(m => m.MaintenanceJobId == e.JobId);
            maintenanceHistory.MaintenanceDate = e.StartTime.Date;
            maintenanceHistory.Description = e.Notes;
            maintenanceHistory.MaintenanceType = MaintenanceTypes.Overig;
            maintenanceHistory.IsCompleted = true;
            await maintenanceHistoryContext.SaveChangesAsync();
        }
        catch (DbUpdateException)
        {
            Log.Warning("Skipped adding hiustory job with id {JobId}.", e.JobId);
        }

        return true;
    }
    
    private Task HandleAsync(MaintenanceHistory history)
    {
        Log.Information("Maintenance history: {JobId}, {JobDescription}, {PlannedMaintenanceDate}, {ActualMaintenanceDate}, {Status}",
            history.MaintenanceJobId, history.Description, history.MaintenanceDate, DateTime.Now, "Overig");
        
        return Task.CompletedTask;
    }
}
