using Microsoft.EntityFrameworkCore;
using PayOffice.DAL.Contexts;
using PayOffice.DAL.IRepositories;
using PayOffice.Domain.Commons;
using System.Linq.Expressions;

namespace PayOffice.DAL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Auditable
    {
        private readonly AppDbContext appDbContext;
        private readonly DbSet<TEntity> dbSet;
        public Repository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
            this.dbSet = appDbContext.Set<TEntity>();
        }

        public async ValueTask<bool> DeleteAsync(Expression<Func<TEntity, bool>> expression)
        {
            var entity = await this.SelectAsync(expression);
            if (entity is not null) 
            {
                return true;
            }
            return false;
        }

        public bool DeleteMany(Expression<Func<TEntity, bool>> expression)
        {
            var entities = dbSet.Where(expression);
            if(entities.Any())
            {
                return true;
            }
            return false;
        }

        public async ValueTask<TEntity> InsertAsync(TEntity entity)
        {
            var entry = await this.dbSet.AddAsync(entity);
            return entry.Entity;
        }

        public async ValueTask SaveChangesAsync()
        {
            await appDbContext.SaveChangesAsync();
        }

        public IQueryable<TEntity> SelectAllAsync(Expression<Func<TEntity, bool>> expression = null, string[] includes = null)
        {
            IQueryable<TEntity> query = expression is null ? this.dbSet : this.dbSet.Where(expression);

            if (includes is not null)
            {
                foreach (string include in includes)
                {
                    query = query.Include(include);
                }
            }

            return query;
        }

        public async ValueTask<TEntity> SelectAsync(Expression<Func<TEntity, bool>> expression, string[] includes = null)
        {
            return await this.SelectAllAsync(expression, includes).FirstOrDefaultAsync();
        }

        public TEntity UpdateAsync(TEntity entity)
        {
            var entry = this.dbSet.Update(entity);
            return entry.Entity;
        }
    }
}
