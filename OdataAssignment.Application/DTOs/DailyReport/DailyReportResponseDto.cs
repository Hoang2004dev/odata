using System.ComponentModel.DataAnnotations;

namespace OdataAssignment.Application.DTOs.DailyReport;

public class DailyReportResponseDto
{
    [Key]
    public long ReportId { get; set; }
    public int LocationId { get; set; }
    public DateTime LastUpdate { get; set; }
    public int Confirmed { get; set; }
    public int Deaths { get; set; }
    public int Recovered { get; set; }
    public int Active { get; set; }
}
