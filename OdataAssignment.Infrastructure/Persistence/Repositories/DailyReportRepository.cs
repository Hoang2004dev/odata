using Microsoft.EntityFrameworkCore;
using OdataAssignment.Application.Interfaces.Repositories;
using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Infrastructure.Persistence.Repositories;

public class DailyReportRepository : IDailyReportRepository
{
    private readonly CovidDbContext _context;

    public DailyReportRepository(CovidDbContext context) => _context = context;

    public IQueryable<DailyReport> Query() =>
        _context.DailyReports.AsNoTracking();

    public async Task<DailyReport?> GetByIdAsync(long id) =>
        await _context.DailyReports.AsNoTracking().FirstOrDefaultAsync(r => r.ReportId == id);
}
