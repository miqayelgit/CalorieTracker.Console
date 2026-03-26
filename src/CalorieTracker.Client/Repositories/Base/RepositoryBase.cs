using CalorieTracker.Client.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CalorieTracker.Client.Repositories.@base;

public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
{

    private DatabaseContext _context;

    public RepositoryBase(DatabaseContext context)
    {
        _context = context;
    }

    public void Add(TEntity entity)
    {
        _context.Set<TEntity>().Add(entity);
    }


    public void Delete(TEntity entity)
    {
        _context.Set<TEntity>().Remove(entity);
    }

    public TEntity Get(Func<TEntity, bool> predicate)
    {
        return _context.Set<TEntity>().Where(predicate).FirstOrDefault()!;
    }

    public IEnumerable<TEntity> GetAll()
    {
        return _context.Set<TEntity>();
    }

    public void Update(TEntity entity)
    {
        _context.Set<TEntity>().Update(entity);
    }

    public void Commit()
    {
        _context.SaveChanges();
    }
}
