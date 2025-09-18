using Microsoft.EntityFrameworkCore;
using OdataAssignment.Application.Interfaces.Repositories;
using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Infrastructure.Persistence.Repositories;

public class RecoveredRepository : IRecoveredRepository
{
    private readonly CovidDbContext _context;

    public RecoveredRepository(CovidDbContext context) => _context = context;

    public IQueryable<Recovered> Query() =>
        _context.Recovered.AsNoTracking();

    public async Task<Recovered?> GetByIdAsync(long id) =>
        await _context.Recovered.AsNoTracking().FirstOrDefaultAsync(r => r.RecordId == id);
}
