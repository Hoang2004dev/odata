namespace OdataAssignment.Domain.Entities;

public class Location
{
    public int LocationId { get; set; }
    public string CountryRegion { get; set; } = string.Empty;
    public string? ProvinceState { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }

    // Navigation properties
    public ICollection<Confirmed> ConfirmedCases { get; set; } = new List<Confirmed>();
    public ICollection<Death> Deaths { get; set; } = new List<Death>();
    public ICollection<Recovered> RecoveredCases { get; set; } = new List<Recovered>();
    public ICollection<DailyReport> DailyReports { get; set; } = new List<DailyReport>();
}
