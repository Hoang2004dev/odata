using System.ComponentModel.DataAnnotations;

namespace OdataAssignment.Application.DTOs.DailyReport;

public class DailyReportResponseDto
{
    [Key]
    public long ReportId { get; set; }
    public int LocationId { get; set; }
    public string CountryRegion { get; set; } = string.Empty;
    public string? ProvinceState { get; set; }
    public DateTime ReportDate { get; set; }

    public int Confirmed { get; set; }
    public int Deaths { get; set; }
    public int Recovered { get; set; }
    public int Active { get; set; }

    public int DailyIncrease { get; set; }
}
