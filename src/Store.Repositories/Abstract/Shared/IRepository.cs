namespace Suzim.Store.Repositories.Abstract.Shared;

public interface IRepository<TEntity>
{
    Task<TEntity?> GetById(Guid id, bool isOnlyActive = true, CancellationToken token = default);
    
    Task<(int total, IReadOnlyList<TEntity> items)> GetAll( bool isOnlyActive = true, CancellationToken token = default);
    
    void Add(TEntity entity);
    
    void Update(TEntity entity);
    
    void Delete(TEntity entity);
}