using Microsoft.EntityFrameworkCore.Design;

namespace Pitstop.MaintenanceHistoryAPI.DataAccess
{
    public class MaintenanceHistoryContextFactory : IDesignTimeDbContextFactory<MaintenanceHistoryContext>
    {
        public MaintenanceHistoryContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.Development.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<MaintenanceHistoryContext>();
            var connectionString = configuration.GetConnectionString("MaintenanceHistoryCN");

            optionsBuilder.UseSqlServer(connectionString);

            return new MaintenanceHistoryContext(optionsBuilder.Options);
        }
    }
}
