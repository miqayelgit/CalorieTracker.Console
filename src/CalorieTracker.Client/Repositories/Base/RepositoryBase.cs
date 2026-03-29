using CalorieTracker.Client.Interfaces.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System.Linq.Expressions;

namespace CalorieTracker.Client.Repositories.@base;

public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
{

    private DatabaseContext _context;

    public RepositoryBase(DatabaseContext context)
    {
        _context = context;
    }

    public void Create(TEntity entity)
    {
        _context.Set<TEntity>().Add(entity);
    }

    public void Delete(TEntity entity)
    {
        _context.Set<TEntity>().Remove(entity);
    }

    public Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
    {
        return _context.Set<TEntity>().Where(predicate).FirstOrDefaultAsync()!;
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _context.Set<TEntity>().ToListAsync();
    }

    public IQueryable<TEntity> GetAllData()
    {
        return _context.Set<TEntity>();
    }

    public void Update(TEntity entity)
    {
        _context.Set<TEntity>().Update(entity);
    }

  
}
