using Microsoft.EntityFrameworkCore;
using OdataAssignment.Application.Interfaces.Repositories;
using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Infrastructure.Persistence.Repositories;

public class DeathRepository : IDeathRepository
{
    private readonly CovidDbContext _context;

    public DeathRepository(CovidDbContext context) => _context = context;

    public async Task<Death?> GetByIdAsync(long id) =>
        await _context.Deaths.FindAsync(id);

    public async Task<IEnumerable<Death>> GetAllAsync() =>
        await _context.Deaths.ToListAsync();

    public async Task<IEnumerable<Death>> GetByLocationAsync(int locationId) =>
        await _context.Deaths
            .Where(d => d.LocationId == locationId)
            .ToListAsync();

    public async Task<IEnumerable<Death>> GetByDateRangeAsync(DateTime startDate, DateTime endDate) =>
        await _context.Deaths
            .Where(d => d.RecordDate >= startDate && d.RecordDate <= endDate)
            .ToListAsync();
}
