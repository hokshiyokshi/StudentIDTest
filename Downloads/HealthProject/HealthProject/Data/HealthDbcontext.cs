using Microsoft.EntityFrameworkCore;
using HealthProject.Models;

namespace HealthProject.Data
{
    public class HealthDbContext : DbContext
    {
        public HealthDbContext(DbContextOptions<HealthDbContext> options)
            : base(options)
        {
        }

        public DbSet<DeviceStatistic> DeviceStatistics { get; set; }
        public DbSet<Measurement> Measurements { get; set; }
        public DbSet<Reminder> Reminders { get; set; }

        // Add DbSets for other entities
    }
}
