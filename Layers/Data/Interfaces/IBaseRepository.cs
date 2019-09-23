using Layers.Domain.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Layers.Data.Interfaces
{
    public interface IBaseRepository<TEntity, TId> 
        where TEntity : IEntity<TId>
        where TId : struct
    {
        IQueryable<TEntity> GetAll();
        TEntity GetById(int id);
        TEntity Add(TEntity entity);
        int Count();
        void Remove(TEntity entity);
        void Dispose();
        TEntity Find(Expression<Func<TEntity, bool>> match);
        ICollection<TEntity> FindAll(Expression<Func<TEntity, bool>> match);
        IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] includeProperties);
        void Save();
        TEntity Update(TEntity entity);
        TEntity UpdateKey(TEntity entity, object key);

    }
}