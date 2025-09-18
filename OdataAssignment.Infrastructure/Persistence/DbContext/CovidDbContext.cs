using Microsoft.EntityFrameworkCore;
using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Infrastructure.Persistence;

public class CovidDbContext : DbContext
{
    public CovidDbContext(DbContextOptions<CovidDbContext> options) : base(options) { }

    public DbSet<Location> Locations { get; set; }
    public DbSet<Confirmed> Confirmed { get; set; }
    public DbSet<Death> Deaths { get; set; }
    public DbSet<Recovered> Recovered { get; set; }
    public DbSet<DailyReport> DailyReports { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CovidDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
