using System.Linq.Expressions;
using GriffonCMS.Core.Context.EFContext;
using GriffonCMS.Domain.Entities.Base;
using GriffonCMS.Domain.Repositories.Base.Abstract;
using Microsoft.EntityFrameworkCore;

namespace GriffonCMS.Core.Repositories.Base;

public class BaseRepository<TEntity, TPK> : IBaseRepository<TEntity, TPK>
    where TPK : notnull
    where TEntity : BaseEntity<TPK> 
{
    #region Props
    private readonly GriffonEFContext _dbContext;
    protected readonly DbSet<TEntity> _dbSet;
    #endregion
    
    #region Methods
    public BaseRepository(GriffonEFContext dbContext)
    {
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        _dbSet = _dbContext.Set<TEntity>();
        _dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    }

    public async Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        await _dbSet.AddAsync(entity, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return entity;
    }

    public async Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
    {
        await _dbSet.AddRangeAsync(entities, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return entities;
    }

    public async Task DeleteByIdAsync(TPK id, CancellationToken cancellationToken = default)
    {
        var result = await _dbSet.AsNoTracking().FirstOrDefaultAsync(q => id.Equals(q.Id), cancellationToken);
        _dbContext.Remove(result);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteAsync(Expression<Func<TEntity, bool>> where, CancellationToken cancellationToken = default)
    {
        var result = await _dbSet.AsNoTracking().Where(where).ToListAsync(cancellationToken);
        _dbSet.RemoveRange(result);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await _dbSet.ToListAsync(cancellationToken);
    }

    public async Task<TEntity> GetByExpressionAsync(Expression<Func<TEntity, bool>> where, CancellationToken cancellationToken = default)
    {
        return await _dbSet.AsNoTracking().FirstOrDefaultAsync(where, cancellationToken);
    }

    public async Task<TEntity> GetByIdAsync(TPK id, CancellationToken cancellationToken = default)
    {
        return await _dbSet.AsNoTracking().FirstOrDefaultAsync(q => id.Equals(q.Id), cancellationToken);
    }

    public async Task<IEnumerable<TEntity>> GetManyAsync(Expression<Func<TEntity, bool>> where, CancellationToken cancellationToken = default)
    {
        return await _dbSet.AsNoTracking().Where(where).ToListAsync(cancellationToken);
    }

    public TEntity Update(TEntity entity)
    {
        _dbSet.Update(entity);
        _dbContext.SaveChangesAsync();
        return entity;
    }

    public IEnumerable<TEntity> UpdateRange(IEnumerable<TEntity> entities)
    {
        _dbSet.UpdateRange(entities);
        _dbContext.SaveChangesAsync();
        return entities;
    }

    public TEntity Get(Expression<Func<TEntity, bool>> filter)
    {
       
            return _dbContext.Set<TEntity>().SingleOrDefault(filter);
        }
    }
 #endregion

