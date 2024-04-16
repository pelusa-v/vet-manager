using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace vet_manager.DataAccess.Repositories.Impl;

public abstract class SimpleRepository<T> : ISimpleRepository<T> where T : class
{
    private readonly AppDbContext _appDbContext;

    public SimpleRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;    
    }

    public async Task<T?> Get(int id)
    {
        return await _appDbContext.Set<T>().FindAsync(id);
    }

    public async Task<T?> Get(Guid id)
    {
        return await _appDbContext.Set<T>().FindAsync(id);
    }

    public async Task<List<T>> List(int limit, int offset)
    {
        return await _appDbContext.Set<T>()
            .Skip(offset)
            .Take(limit)
            .ToListAsync();
    }

    public async Task<List<T>> Search(Expression<Func<T, bool>> filter, int limit = 10, int offset = 0)
    {
        return await _appDbContext.Set<T>()
            .Where(filter)
            .Skip(offset)
            .Take(limit)
            .ToListAsync();
    }

    public async Task Create(T entity)
    {
        await _appDbContext.Set<T>().AddAsync(entity);
        await _appDbContext.SaveChangesAsync();
    }

    public async Task Update(T entity)
    {
        _appDbContext.Set<T>().Update(entity);
        await _appDbContext.SaveChangesAsync();
    }

    public async Task Delete(T entity)
    {
        _appDbContext.Set<T>().Remove(entity);
        await _appDbContext.SaveChangesAsync();
    }

    public Task<bool> Exist(Expression<Func<T, bool>> filter)
    {
        return _appDbContext.Set<T>().AnyAsync(filter);
    }

    public Task<int> Count(Expression<Func<T, bool>> filter)
    {
        return _appDbContext.Set<T>().CountAsync(filter);
    }

    public async Task<int> Count()
    {
        return await _appDbContext.Set<T>().CountAsync();
    }
}
