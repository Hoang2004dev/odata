using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Infrastructure.Persistence.Configurations;

public class LocationConfiguration : IEntityTypeConfiguration<Location>
{
    public void Configure(EntityTypeBuilder<Location> builder)
    {
        builder.ToTable("locations");

        builder.HasKey(l => l.LocationId);

        builder.Property(l => l.LocationId).HasColumnName("location_id");
        builder.Property(l => l.CountryRegion).HasColumnName("country_region").HasMaxLength(200).IsRequired();
        builder.Property(l => l.ProvinceState).HasColumnName("province_state").HasMaxLength(200);
        builder.Property(l => l.Latitude).HasColumnName("latitude");
        builder.Property(l => l.Longitude).HasColumnName("longitude");

        builder.HasIndex(l => new { l.CountryRegion, l.ProvinceState, l.Latitude, l.Longitude }).IsUnique();
    }
}
