using FiveStarRepos.Domain.Base;
using FiveStarRepos.Infra.Data.Repositories.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FiveStarRepos.Infra.Data.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        public Task<IEnumerable<TEntity>> AllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CommitAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FindByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(TEntity TEntity)
        {
            throw new NotImplementedException();
        }

        public Task InsertManyAsync(TEntity[] entities)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TEntity TEntity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> WhereAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
