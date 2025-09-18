using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Application.Interfaces.Repositories;

public interface IRecoveredRepository : IRepository<Recovered>
{
    Task<IEnumerable<Recovered>> GetByLocationAsync(int locationId);
    Task<IEnumerable<Recovered>> GetByDateRangeAsync(DateTime startDate, DateTime endDate);
}
