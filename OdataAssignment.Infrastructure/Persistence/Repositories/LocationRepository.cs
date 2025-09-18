using Microsoft.EntityFrameworkCore;
using OdataAssignment.Application.Interfaces.Repositories;
using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Infrastructure.Persistence.Repositories;

public class LocationRepository : ILocationRepository
{
    private readonly CovidDbContext _context;

    public LocationRepository(CovidDbContext context) => _context = context;

    public IQueryable<Location> Query() =>
        _context.Locations.AsNoTracking();

    public async Task<Location?> GetByIdAsync(long id) =>
        await _context.Locations.AsNoTracking().FirstOrDefaultAsync(l => l.LocationId == id);
}
