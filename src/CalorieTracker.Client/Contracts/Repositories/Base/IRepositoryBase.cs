using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CalorieTracker.Client.Contracts.Interfaces.Base;

public interface IRepositoryBase<TEntity> where TEntity : class

{
    public void Create(TEntity entity);
    public Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>>? predicate = null);
    public Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? predicate = null);
    public void Update(TEntity entity);
    public void Delete(TEntity entity);
}
