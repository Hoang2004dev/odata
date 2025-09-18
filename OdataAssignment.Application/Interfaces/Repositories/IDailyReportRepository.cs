using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Application.Interfaces.Repositories;

public interface IDailyReportRepository : IRepository<DailyReport, long>
{
    Task<DailyReport?> GetByLocationAndDateAsync(int locationId, DateTime date);
    Task<List<DailyReport>> GetByDateAsync(DateTime date);
    Task<List<DailyReport>> GetByLocationAsync(int locationId);
}