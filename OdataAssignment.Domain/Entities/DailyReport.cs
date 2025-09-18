namespace OdataAssignment.Domain.Entities;

public class DailyReport
{
    public long ReportId { get; set; }
    public int LocationId { get; set; }
    public DateTime LastUpdate { get; set; }

    public int Confirmed { get; set; } = 0;
    public int Deaths { get; set; } = 0;
    public int Recovered { get; set; } = 0;
    public int Active { get; set; } = 0;

    public string? Fips { get; set; }
    public double? IncidentRate { get; set; }
    public long? TotalTestResults { get; set; }
    public long? PeopleHospitalized { get; set; }
    public double? CaseFatalityRatio { get; set; }
    public long? Uid { get; set; }
    public string? Iso3 { get; set; }
    public double? TestingRate { get; set; }
    public double? HospitalizationRate { get; set; }
    public DateTime? ReportDate { get; set; }
    public long? PeopleTested { get; set; }
    public double? MortalityRate { get; set; }
    public Location Location { get; set; } = null!;
}
