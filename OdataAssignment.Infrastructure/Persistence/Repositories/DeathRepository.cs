using Microsoft.EntityFrameworkCore;
using OdataAssignment.Application.Interfaces.Repositories;
using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Infrastructure.Persistence.Repositories;

public class DeathRepository : Repository<Death, long>, IDeathRepository
{
    public DeathRepository(CovidDbContext context) : base(context) { }
}
