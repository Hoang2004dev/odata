using Microsoft.EntityFrameworkCore;
using OdataAssignment.Application.Interfaces.Repositories;
using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Infrastructure.Persistence.Repositories;

public class ConfirmedRepository : IConfirmedRepository
{
    private readonly CovidDbContext _context;

    public ConfirmedRepository(CovidDbContext context) => _context = context;

    public async Task<Confirmed?> GetByIdAsync(long id) =>
        await _context.Confirmed.FindAsync(id);

    public async Task<IEnumerable<Confirmed>> GetAllAsync() =>
        await _context.Confirmed.ToListAsync();

    public async Task<IEnumerable<Confirmed>> GetByLocationAsync(int locationId) =>
        await _context.Confirmed
            .Where(c => c.LocationId == locationId)
            .ToListAsync();

    public async Task<IEnumerable<Confirmed>> GetByDateRangeAsync(DateTime startDate, DateTime endDate) =>
        await _context.Confirmed
            .Where(c => c.RecordDate >= startDate && c.RecordDate <= endDate)
            .ToListAsync();
}
