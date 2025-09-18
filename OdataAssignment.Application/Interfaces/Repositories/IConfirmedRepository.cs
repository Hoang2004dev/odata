using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Application.Interfaces.Repositories;

public interface IConfirmedRepository : IRepository<Confirmed>
{
    Task<IEnumerable<Confirmed>> GetByLocationAsync(int locationId);
    Task<IEnumerable<Confirmed>> GetByDateRangeAsync(DateTime startDate, DateTime endDate);
}
