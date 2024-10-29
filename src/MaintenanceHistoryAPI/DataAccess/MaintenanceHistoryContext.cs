namespace Pitstop.MaintenanceHistoryAPI.DataAccess
{
    public class MaintenanceHistoryContext : DbContext
    {
        public MaintenanceHistoryContext(DbContextOptions<MaintenanceHistoryContext> options)
            : base(options)
        {
        }

        public DbSet<MaintenanceHistory> MaintenanceHistories { get; set; }
        public DbSet<UsedPart> UsedParts { get; set; }
        public DbSet<RepairPart> RepairParts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<MaintenanceHistory>().HasKey(m => m.Id);
            builder.Entity<MaintenanceHistory>().ToTable("MaintenanceHistory");

            builder.Entity<UsedPart>().HasKey(u => u.Id);
            builder.Entity<UsedPart>().ToTable("UsedParts");

            builder.Entity<RepairPart>().HasKey(r => r.Id);
            builder.Entity<RepairPart>().ToTable("RepairParts");

            base.OnModelCreating(builder);
        }

        public void MigrateDB()
        {
            Policy
                .Handle<Exception>()
                .WaitAndRetry(10, r => TimeSpan.FromSeconds(10))
                .Execute(() => Database.Migrate());
        }
    }
}
