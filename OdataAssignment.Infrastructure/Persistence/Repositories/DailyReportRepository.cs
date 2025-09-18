using Microsoft.EntityFrameworkCore;
using OdataAssignment.Application.Interfaces.Repositories;
using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Infrastructure.Persistence.Repositories;

public class DailyReportRepository : Repository<DailyReport, long>, IDailyReportRepository
{
    public DailyReportRepository(CovidDbContext context) : base(context) { }

    public async Task<DailyReport?> GetByLocationAndDateAsync(int locationId, DateTime date)
    {
        return await _context.DailyReports
            .AsNoTracking()
            .FirstOrDefaultAsync(r => r.LocationId == locationId && r.ReportDate == date.Date);
    }

    public async Task<List<DailyReport>> GetByDateAsync(DateTime date)
    {
        return await _context.DailyReports
            .AsNoTracking()
            .Where(r => r.ReportDate == date.Date)
            .ToListAsync();
    }

    public async Task<List<DailyReport>> GetByLocationAsync(int locationId)
    {
        return await _context.DailyReports
            .AsNoTracking()
            .Where(r => r.LocationId == locationId)
            .OrderBy(r => r.ReportDate)
            .ToListAsync();
    }
}
