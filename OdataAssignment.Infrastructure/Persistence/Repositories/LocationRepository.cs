using Microsoft.EntityFrameworkCore;
using OdataAssignment.Application.Interfaces.Repositories;
using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Infrastructure.Persistence.Repositories;

public class LocationRepository : Repository<Location, int>, ILocationRepository
{
    public LocationRepository(CovidDbContext context) : base(context) { }
}
