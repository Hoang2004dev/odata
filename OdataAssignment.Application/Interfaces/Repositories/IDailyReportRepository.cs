using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Application.Interfaces.Repositories;

public interface IDailyReportRepository : IRepository<DailyReport>
{
    Task<IEnumerable<DailyReport>> GetByLocationAsync(int locationId);
    Task<IEnumerable<DailyReport>> GetByDateAsync(DateTime date);
}
