using OdataAssignment.Domain.Entities;

namespace OdataAssignment.Application.Interfaces.Repositories;

public interface IConfirmedRepository : IRepository<Confirmed>
{
    IQueryable<Confirmed> Query();
}
