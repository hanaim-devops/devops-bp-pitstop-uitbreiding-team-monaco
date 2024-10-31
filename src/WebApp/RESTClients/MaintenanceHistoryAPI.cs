namespace WebApp.RESTClients;

public class MaintenanceHistoryAPI : IMaintenanceHistoryAPI
{
    private IMaintenanceHistoryAPI _restClient;
    
    public MaintenanceHistoryAPI(IConfiguration config, HttpClient httpClient)
    {
        string apiHostAndPort = config.GetSection("APIServiceLocations").GetValue<string>("MaintenanceHistoryAPI");
        httpClient.BaseAddress = new Uri($"http://{apiHostAndPort}/api");
        _restClient = RestService.For<IMaintenanceHistoryAPI>(
            httpClient,
            new RefitSettings
            {
                ContentSerializer = new NewtonsoftJsonContentSerializer()
            });
    }

    public async Task<MaintenanceHistory> GetHistoryById(int id)
    {
        try
        {
            return await _restClient.GetHistoryById(id);
        }
        catch (ApiException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
        {
            // If the ID isn't found, return null (no maintenance history)
            return null;
        }
        catch (HttpRequestException) // This catches network-related issues
        {
            // Handle DNS issues or service unavailability
            return null;
        }
        catch (Exception ex)
        {
            // Log other unexpected exceptions if necessary
            Console.WriteLine($"Unexpected error: {ex.Message}");
            return null;
        }
    }

    public async Task<List<MaintenanceHistory>> GetHistoryByLicenseNumber(string licenseNumber)
    {
        try
        {
            return await _restClient.GetHistoryByLicenseNumber(licenseNumber);
        }
        catch (ApiException ex) when (ex.StatusCode == HttpStatusCode.NotFound)
        {
            // If the ID isn't found, return null (no maintenance history)
            return null;
        }
        catch (HttpRequestException) // This catches network-related issues
        {
            // Handle DNS issues or service unavailability
            return null;
        }
        catch (Exception ex)
        {
            // Log other unexpected exceptions if necessary
            Console.WriteLine($"Unexpected error: {ex.Message}");
            return null;
        }
    }
}