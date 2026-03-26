

using System.Linq.Expressions;

namespace CalorieTracker.Client.Interfaces;

public interface IRepositoryBase<TEntity> 

{
    public void Add(TEntity entity);
    public Task<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
    public Task<IEnumerable<TEntity>> GetAll();

    public void Update(TEntity entity);
    public void Delete(TEntity entity);
}
