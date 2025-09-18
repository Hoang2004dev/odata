namespace OdataAssignment.Application.Interfaces.Repositories;

public interface IRepository<T, TKey> where T : class
{
    IQueryable<T> Query();
    Task<T?> GetByIdAsync(TKey id);
}
