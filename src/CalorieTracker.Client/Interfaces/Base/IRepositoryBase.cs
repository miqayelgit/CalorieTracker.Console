using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CalorieTracker.Client.Interfaces.Base;

public interface IRepositoryBase<TEntity> where TEntity : class

{
    public void Create(TEntity entity);
    public Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
    public Task<IEnumerable<TEntity>> GetAllAsync();
    public IQueryable<TEntity> GetAllData();
    public void Update(TEntity entity);
    public void Delete(TEntity entity);
}
