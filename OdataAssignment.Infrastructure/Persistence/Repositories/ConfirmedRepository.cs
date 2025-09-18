using OdataAssignment.Application.Interfaces.Repositories;
using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Infrastructure.Persistence.Repositories;

public class ConfirmedRepository : Repository<Confirmed, long>, IConfirmedRepository
{
    public ConfirmedRepository(CovidDbContext context) : base(context) { }
}
