using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Infrastructure.Persistence.Configurations;

public class RecoveredConfiguration : IEntityTypeConfiguration<Recovered>
{
    public void Configure(EntityTypeBuilder<Recovered> builder)
    {
        builder.ToTable("recovered");

        builder.HasKey(r => r.RecordId);

        builder.Property(r => r.RecordId).HasColumnName("record_id");
        builder.Property(r => r.LocationId).HasColumnName("location_id");
        builder.Property(r => r.RecordDate).HasColumnName("record_date");
        builder.Property(r => r.Quantity).HasColumnName("quantity");

        builder.HasIndex(r => new { r.LocationId, r.RecordDate }).IsUnique();

        builder.HasOne(r => r.Location)
            .WithMany(l => l.RecoveredCases)
            .HasForeignKey(r => r.LocationId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
