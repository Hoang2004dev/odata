using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Infrastructure.Persistence.Configurations;

public class ConfirmedConfiguration : IEntityTypeConfiguration<Confirmed>
{
    public void Configure(EntityTypeBuilder<Confirmed> builder)
    {
        builder.ToTable("confirmed");

        builder.HasKey(c => c.RecordId);

        builder.Property(c => c.RecordId).HasColumnName("record_id");
        builder.Property(c => c.LocationId).HasColumnName("location_id");
        builder.Property(c => c.RecordDate).HasColumnName("record_date");
        builder.Property(c => c.Quantity).HasColumnName("quantity");

        builder.HasIndex(c => new { c.LocationId, c.RecordDate }).IsUnique();

        builder.HasOne(c => c.Location)
            .WithMany(l => l.ConfirmedCases)
            .HasForeignKey(c => c.LocationId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
