using System.ComponentModel.DataAnnotations;

namespace OdataAssignment.Application.DTOs.Death;

public class DeathResponseDto
{
    [Key]
    public long RecordId { get; set; }
    public int LocationId { get; set; }
    public DateTime RecordDate { get; set; }
    public int Quantity { get; set; }
}
