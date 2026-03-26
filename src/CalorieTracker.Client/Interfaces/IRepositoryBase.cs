

using System.Linq.Expressions;

namespace CalorieTracker.Client.Interfaces;

public interface IRepositoryBase<TEntity> 

{
    public void Create(TEntity entity);
    public Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate);
    public Task<IEnumerable<TEntity>> GetAllAsync();

    public void Update(TEntity entity);
    public void Delete(TEntity entity);
}
