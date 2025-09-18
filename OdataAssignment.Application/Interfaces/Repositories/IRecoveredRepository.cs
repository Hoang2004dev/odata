using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Application.Interfaces.Repositories;

public interface IRecoveredRepository : IRepository<Recovered>
{
    IQueryable<Recovered> Query();
}
