using OdataAssignment.Application.DTOs.Location;
using System.ComponentModel.DataAnnotations;

namespace OdataAssignment.Application.DTOs.DailyReport;

public class DailyReportResponseDto
{
    [Key]
    public long ReportId { get; set; }
    public int LocationId { get; set; }
    public DateTime LastUpdate { get; set; }
    public DateTime? ReportDate { get; set; }

    public int Confirmed { get; set; }
    public int Deaths { get; set; }
    public int Recovered { get; set; }
    public int Active { get; set; }

    public string? Fips { get; set; }
    public double? IncidentRate { get; set; }
    public long? TotalTestResults { get; set; }
    public long? PeopleHospitalized { get; set; }
    public double? CaseFatalityRatio { get; set; }
    public long? Uid { get; set; }
    public string? Iso3 { get; set; }
    public double? TestingRate { get; set; }
    public double? HospitalizationRate { get; set; }
    public long? PeopleTested { get; set; }
    public double? MortalityRate { get; set; }

    public LocationResponseDto Location { get; set; } = null!;
}
