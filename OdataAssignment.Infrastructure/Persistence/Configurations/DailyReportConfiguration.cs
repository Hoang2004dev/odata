using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Infrastructure.Persistence.Configurations;

public class DailyReportConfiguration : IEntityTypeConfiguration<DailyReport>
{
    public void Configure(EntityTypeBuilder<DailyReport> builder)
    {
        builder.ToTable("daily_reports");

        builder.HasKey(r => r.ReportId);

        builder.Property(r => r.ReportId).HasColumnName("report_id");
        builder.Property(r => r.LocationId).HasColumnName("location_id");
        builder.Property(r => r.LastUpdate).HasColumnName("last_update");
        builder.Property(r => r.Confirmed).HasColumnName("confirmed");
        builder.Property(r => r.Deaths).HasColumnName("deaths");
        builder.Property(r => r.Recovered).HasColumnName("recovered");
        builder.Property(r => r.Active).HasColumnName("active");
        builder.Property(r => r.Fips).HasColumnName("fips");
        builder.Property(r => r.IncidentRate).HasColumnName("incident_rate");
        builder.Property(r => r.TotalTestResults).HasColumnName("total_test_results");
        builder.Property(r => r.PeopleHospitalized).HasColumnName("people_hospitalized");
        builder.Property(r => r.CaseFatalityRatio).HasColumnName("case_fatality_ratio");
        builder.Property(r => r.Uid).HasColumnName("uid");
        builder.Property(r => r.Iso3).HasColumnName("iso3");
        builder.Property(r => r.TestingRate).HasColumnName("testing_rate");
        builder.Property(r => r.HospitalizationRate).HasColumnName("hospitalization_rate");
        builder.Property(r => r.ReportDate).HasColumnName("report_date");
        builder.Property(r => r.PeopleTested).HasColumnName("people_tested");
        builder.Property(r => r.MortalityRate).HasColumnName("mortality_rate");

        builder.HasIndex(r => new { r.LocationId, r.LastUpdate }).IsUnique();

        builder.HasOne(r => r.Location)
            .WithMany(l => l.DailyReports)
            .HasForeignKey(r => r.LocationId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
