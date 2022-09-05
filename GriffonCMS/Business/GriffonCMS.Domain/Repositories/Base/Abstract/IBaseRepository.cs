using System.Linq.Expressions;

namespace GriffonCMS.Domain.Repositories.Base.Abstract;

public interface IBaseRepository<TEntity, TPK>
{
    Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default);
    Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);
    Task DeleteByIdAsync(TPK id, CancellationToken cancellationToken = default);
    Task DeleteAsync(Expression<Func<TEntity, bool>> where, CancellationToken cancellationToken = default);
    Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<TEntity> GetByExpressionAsync(Expression<Func<TEntity, bool>> where, CancellationToken cancellationToken = default);
    Task<TEntity> GetByIdAsync(TPK id, CancellationToken cancellationToken = default);
    Task<IEnumerable<TEntity>> GetManyAsync(Expression<Func<TEntity, bool>> where, CancellationToken cancellationToken = default);
    TEntity Update(TEntity entity);
    IEnumerable<TEntity> UpdateRange(IEnumerable<TEntity> entities);
    TEntity Get(Expression<Func<TEntity, bool>> filter);
}