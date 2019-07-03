using Layers.Domain.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Layers.Data.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : IEntity
    {
        TEntity Add(TEntity t);
        int Count();
        void Delete(TEntity entity);
        void Dispose();
        TEntity Find(Expression<Func<TEntity, bool>> match);
        ICollection<TEntity> FindAll(Expression<Func<TEntity, bool>> match);
        IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);
        TEntity Get(int id);
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] includeProperties);
        void Save();
        TEntity Update(TEntity t);
        TEntity UpdateKey(TEntity t, object key);

    }
}