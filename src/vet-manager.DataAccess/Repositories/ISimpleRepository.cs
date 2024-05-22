using System.Linq.Expressions;

namespace vet_manager.DataAccess.Repositories;

public interface ISimpleRepository<T>
{
    Task<T?> Get(int id);
    Task<T?> Get(Guid id);
    Task<List<T>> List(int limit = 10, int offset = 0);
    Task<List<T>> List();
    Task<List<T>> Search(Expression<Func<T, bool>> filter, int limit = 10, int offset = 0);
    Task Create(T entity);
    Task Update(T entity);
    Task Delete(T entity);
    Task<bool> Exist(Expression<Func<T, bool>> filter);
    Task<int> Count(Expression<Func<T, bool>> filter);
    Task<int> Count();
}
