using Microsoft.EntityFrameworkCore;
using OdataAssignment.Application.Interfaces.Repositories;
using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Infrastructure.Persistence.Repositories;

public class LocationRepository : ILocationRepository
{
    private readonly CovidDbContext _context;

    public LocationRepository(CovidDbContext context)
    {
        _context = context;
    }

    public async Task<Location?> GetByIdAsync(long id) =>
        await _context.Locations.FindAsync((int)id);

    public async Task<IEnumerable<Location>> GetAllAsync() =>
        await _context.Locations.ToListAsync();

    public async Task<Location?> GetByCountryAsync(string countryRegion) =>
        await _context.Locations
            .FirstOrDefaultAsync(l => l.CountryRegion == countryRegion);

    public async Task<IEnumerable<Location>> SearchAsync(string keyword) =>
        await _context.Locations
            .Where(l => l.CountryRegion.Contains(keyword) ||
                        (l.ProvinceState != null && l.ProvinceState.Contains(keyword)))
            .ToListAsync();
}
