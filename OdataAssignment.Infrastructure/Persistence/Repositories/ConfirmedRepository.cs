using Microsoft.EntityFrameworkCore;
using OdataAssignment.Application.Interfaces.Repositories;
using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Infrastructure.Persistence.Repositories;

public class ConfirmedRepository : IConfirmedRepository
{
    private readonly CovidDbContext _context;

    public ConfirmedRepository(CovidDbContext context) => _context = context;

    public IQueryable<Confirmed> Query() =>
        _context.Confirmed.AsNoTracking();

    public async Task<Confirmed?> GetByIdAsync(long id) =>
        await _context.Confirmed.AsNoTracking().FirstOrDefaultAsync(c => c.RecordId == id);
}
