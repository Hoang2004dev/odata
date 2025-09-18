using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Application.Interfaces.Repositories;

public interface ILocationRepository : IRepository<Location>
{
    Task<Location?> GetByCountryAsync(string countryRegion);
    Task<IEnumerable<Location>> SearchAsync(string keyword);
}
