using Microsoft.EntityFrameworkCore;
using OdataAssignment.Application.Interfaces.Repositories;
using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Infrastructure.Persistence.Repositories;

public class DailyReportRepository : IDailyReportRepository
{
    private readonly CovidDbContext _context;

    public DailyReportRepository(CovidDbContext context) => _context = context;

    public async Task<DailyReport?> GetByIdAsync(long id) =>
        await _context.DailyReports.FindAsync(id);

    public async Task<IEnumerable<DailyReport>> GetAllAsync() =>
        await _context.DailyReports.ToListAsync();

    public async Task<IEnumerable<DailyReport>> GetByLocationAsync(int locationId) =>
        await _context.DailyReports
            .Where(r => r.LocationId == locationId)
            .ToListAsync();

    public async Task<IEnumerable<DailyReport>> GetByDateAsync(DateTime date) =>
        await _context.DailyReports
            .Where(r => r.ReportDate == date.Date)
            .ToListAsync();
}
