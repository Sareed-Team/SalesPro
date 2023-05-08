﻿using System.Linq.Expressions;

namespace PayOffice.DAL.IRepositories
{
    public interface IRepository<TEntity>
    {
        ValueTask<TEntity> InsertAsync(TEntity entity);
        TEntity UpdateAsync(TEntity entity);
        IQueryable<TEntity> SelectAllAsync(Expression<Func<TEntity, bool>> expression = null, string[] includes = null);
        ValueTask<TEntity> SelectAsync(Expression<Func<TEntity, bool>> expression, string[] includes = null);
        ValueTask<bool> DeleteAsync(Expression<Func<TEntity, bool>> expression);
        bool DeleteMany(Expression<Func<TEntity, bool>> expression);
        ValueTask SaveChangesAsync();
    }
}