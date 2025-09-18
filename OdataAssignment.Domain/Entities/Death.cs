namespace OdataAssignment.Domain.Entities;

public class Death
{
    public long RecordId { get; set; }
    public int LocationId { get; set; }
    public DateTime RecordDate { get; set; }
    public int Quantity { get; set; }
    public Location Location { get; set; } = null!;
}
