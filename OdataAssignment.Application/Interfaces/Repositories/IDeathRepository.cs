using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Application.Interfaces.Repositories;

public interface IDeathRepository : IRepository<Death>
{
    IQueryable<Death> Query();
}
