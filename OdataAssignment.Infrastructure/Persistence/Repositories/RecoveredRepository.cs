using Microsoft.EntityFrameworkCore;
using OdataAssignment.Application.Interfaces.Repositories;
using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Infrastructure.Persistence.Repositories;

public class RecoveredRepository : IRecoveredRepository
{
    private readonly CovidDbContext _context;

    public RecoveredRepository(CovidDbContext context) => _context = context;

    public async Task<Recovered?> GetByIdAsync(long id) =>
        await _context.Recovered.FindAsync(id);

    public async Task<IEnumerable<Recovered>> GetAllAsync() =>
        await _context.Recovered.ToListAsync();

    public async Task<IEnumerable<Recovered>> GetByLocationAsync(int locationId) =>
        await _context.Recovered
            .Where(r => r.LocationId == locationId)
            .ToListAsync();

    public async Task<IEnumerable<Recovered>> GetByDateRangeAsync(DateTime startDate, DateTime endDate) =>
        await _context.Recovered
            .Where(r => r.RecordDate >= startDate && r.RecordDate <= endDate)
            .ToListAsync();
}
