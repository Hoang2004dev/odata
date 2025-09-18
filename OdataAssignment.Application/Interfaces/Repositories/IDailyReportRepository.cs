using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Application.Interfaces.Repositories;

public interface IDailyReportRepository : IRepository<DailyReport>
{
    IQueryable<DailyReport> Query();
}
