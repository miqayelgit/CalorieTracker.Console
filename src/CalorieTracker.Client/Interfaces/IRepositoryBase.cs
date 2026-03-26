

namespace CalorieTracker.Client.Interfaces;

internal interface IRepositoryBase<TEntity> 

{
    public void Add(TEntity entity);
    public TEntity Get(Func<TEntity, bool> predicate);
    public IEnumerable<TEntity> GetAll();

    public void Update(TEntity entity);
    public void Delete(TEntity entity);

}
