using Microsoft.EntityFrameworkCore;
using OdataAssignment.Application.Interfaces.Repositories;
using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Infrastructure.Persistence.Repositories;

public class RecoveredRepository : Repository<Recovered, long>, IRecoveredRepository
{
    public RecoveredRepository(CovidDbContext context) : base(context) { }
}
