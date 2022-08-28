using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Domain.Entities.Base;

namespace GriffonCMS.Domain.Repositories.Base;
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
}
