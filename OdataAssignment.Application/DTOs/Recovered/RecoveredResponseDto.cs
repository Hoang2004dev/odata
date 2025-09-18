using OdataAssignment.Application.DTOs.Location;
using System.ComponentModel.DataAnnotations;

namespace OdataAssignment.Application.DTOs.Recovered;

public class RecoveredResponseDto
{
    [Key]
    public long RecordId { get; set; }
    public int LocationId { get; set; }
    public DateTime RecordDate { get; set; }
    public int Quantity { get; set; }

    public LocationResponseDto Location { get; set; } = null!;
}
