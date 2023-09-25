using Microsoft.EntityFrameworkCore;

namespace Suzim.Store.Repositories.Abstract.Shared;

public abstract class Repository<TEntity> : IDbRepository, IRepository<TEntity> where TEntity : class
{
    private readonly DbContext _dbContext;
    private readonly DbSet<TEntity> _dbSet;

    internal Repository(DbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = dbContext.Set<TEntity>();
    }
    
    public Task<TEntity?> GetById(Guid id, bool isOnlyActive = true, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public Task<(int total, IReadOnlyList<TEntity> items)> GetAll(bool isOnlyActive = true, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public void Add(TEntity entity)
    {
        _dbSet.Add(entity);
    }

    public void Update(TEntity entity)
    {
        _dbContext.Entry(entity).State = EntityState.Modified;
    }

    public void Delete(TEntity entity)
    {
        _dbSet.Remove(entity);
    }
}