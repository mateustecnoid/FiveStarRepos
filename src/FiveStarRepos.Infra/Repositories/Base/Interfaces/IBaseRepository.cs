using FiveStarRepos.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FiveStarRepos.Infra.Data.Repositories.Base.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> FindByIdAsync(long id);
        Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> predicate);
        Task<IEnumerable<TEntity>> AllAsync();
        Task<IEnumerable<TEntity>> WhereAsync(Expression<Func<TEntity, bool>> predicate);
        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate);
        Task DeleteAsync(TEntity entity);
        Task DeleteAsync(long id);
        Task InsertAsync(TEntity TEntity);
        Task InsertManyAsync(TEntity[] entities);
        Task<bool> CommitAsync();
        Task UpdateAsync(TEntity TEntity);
        Task<int> CountAsync();
    }
}
