using PayOffice.DAL.IRepositories;
using PayOffice.Domain.Commons;
using System.Linq.Expressions;

namespace PayOffice.DAL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Auditable
    {
        public ValueTask<bool> DeleteAsync(Expression<Func<TEntity, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public bool DeleteMany(Expression<Func<TEntity, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public ValueTask<TEntity> InsertAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public ValueTask SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> SelectAllAsync(Expression<Func<TEntity, bool>> expression = null, string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public ValueTask<TEntity> SelectAsync(Expression<Func<TEntity, bool>> expression, string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public TEntity UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
