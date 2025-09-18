using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Application.Interfaces.Repositories;

public interface IDeathRepository : IRepository<Death>
{
    Task<IEnumerable<Death>> GetByLocationAsync(int locationId);
    Task<IEnumerable<Death>> GetByDateRangeAsync(DateTime startDate, DateTime endDate);
}
