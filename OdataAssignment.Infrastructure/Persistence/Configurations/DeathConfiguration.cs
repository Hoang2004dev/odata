using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Infrastructure.Persistence.Configurations;

public class DeathConfiguration : IEntityTypeConfiguration<Death>
{
    public void Configure(EntityTypeBuilder<Death> builder)
    {
        builder.ToTable("deaths");

        builder.HasKey(d => d.RecordId);

        builder.Property(d => d.RecordId).HasColumnName("record_id");
        builder.Property(d => d.LocationId).HasColumnName("location_id");
        builder.Property(d => d.RecordDate).HasColumnName("record_date");
        builder.Property(d => d.Quantity).HasColumnName("quantity");

        builder.HasIndex(d => new { d.LocationId, d.RecordDate }).IsUnique();

        builder.HasOne(d => d.Location)
            .WithMany(l => l.Deaths)
            .HasForeignKey(d => d.LocationId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
