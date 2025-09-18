using Microsoft.EntityFrameworkCore;
using OdataAssignment.Application.Interfaces.Repositories;
using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Infrastructure.Persistence.Repositories;

public class DeathRepository : IDeathRepository
{
    private readonly CovidDbContext _context;

    public DeathRepository(CovidDbContext context) => _context = context;

    public IQueryable<Death> Query() =>
        _context.Deaths.AsNoTracking();

    public async Task<Death?> GetByIdAsync(long id) =>
        await _context.Deaths.AsNoTracking().FirstOrDefaultAsync(d => d.RecordId == id);
}
