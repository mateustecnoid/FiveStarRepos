using FiveStarRepos.Domain.Base;
using FiveStarRepos.Infra.Data.Repositories.Base.Interfaces;
using FiveStarRepos.Infra.Data.Repositories.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FiveStarRepos.Infra.Data.Repositories.Base
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected DbSet<TEntity> Set;
        private readonly FiveStarReposContext Context;

        protected BaseRepository(FiveStarReposContext componenteContext)
        {
            Set = componenteContext.Set<TEntity>();
            Context = componenteContext;
        }
        public virtual async Task<IEnumerable<TEntity>> AllAsync()
        {
            return await Set.ToListAsync();
        }

        public virtual Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return Set.AnyAsync(predicate);
        }

        public virtual Task DeleteAsync(TEntity entity)
        {
            Set.Remove(entity);
            Set.Attach(entity).State = EntityState.Deleted;
            return Task.CompletedTask;
        }

        public virtual Task DeleteAsync(long id)
        {
            var TEntity = Set.Find(id);
            return DeleteAsync(TEntity);
        }

        public virtual Task<TEntity> FindByIdAsync(long id)
        {
            return Set.FirstOrDefaultAsync(x => x.Id == id);
        }

        public virtual async Task<bool> CommitAsync()
        {
            return (await Context.SaveChangesAsync()) > 0;
        }

        public virtual Task InsertAsync(TEntity TEntity)
        {
            return Set.AddAsync(TEntity).AsTask();
        }

        public Task InsertManyAsync(TEntity[] entities)
        {
            return Set.AddRangeAsync(entities);
        }

        public virtual Task UpdateAsync(TEntity TEntity)
        {
            Set.Update(TEntity);
            return Task.CompletedTask;
        }

        public async virtual Task<IEnumerable<TEntity>> WhereAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var data = await Set.Where(predicate).ToListAsync();
            return data;
        }

        public Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return Set.FirstOrDefaultAsync(predicate);
        }

        public async Task<int> CountAsync()
        {
            return await Set.CountAsync();
        }

        public void ClearTable()
        {
           Set.RemoveRange(Set);
        }
    }
}
