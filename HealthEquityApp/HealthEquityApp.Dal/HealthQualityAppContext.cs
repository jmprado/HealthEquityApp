using HealthEquityApp.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace HealthEquityApp.Dal
{
    public class HealthQualityAppContext : DbContext
    {
        public HealthQualityAppContext()
        {
        }

        public HealthQualityAppContext(DbContextOptions<HealthQualityAppContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }

        // Setup in memory database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseInMemoryDatabase("health_quality_db");
            }
        }
    }
}
