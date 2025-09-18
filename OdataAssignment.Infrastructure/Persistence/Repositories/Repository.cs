using Microsoft.EntityFrameworkCore;
using OdataAssignment.Application.Interfaces.Repositories;

namespace OdataAssignment.Infrastructure.Persistence.Repositories;

public class Repository<T, TKey> : IRepository<T, TKey> where T : class
{
    protected readonly CovidDbContext _context;

    public Repository(CovidDbContext context)
    {
        _context = context;
    }

    public IQueryable<T> Query() => _context.Set<T>().AsNoTracking();

    public async Task<T?> GetByIdAsync(TKey id)
    {
        return await _context.Set<T>().FindAsync(id);
    }
}
