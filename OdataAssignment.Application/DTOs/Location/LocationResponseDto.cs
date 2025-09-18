using System.ComponentModel.DataAnnotations;

namespace OdataAssignment.Application.DTOs.Location;

public class LocationResponseDto
{
    [Key]
    public int LocationId { get; set; }
    public string CountryRegion { get; set; } = string.Empty;
    public string? ProvinceState { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
}
