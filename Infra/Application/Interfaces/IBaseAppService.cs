using HeroAPI.Infra.Domain.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace HeroAPI.Infra.Application.Interfaces
{
    public interface IBaseAppService<TEntity> where TEntity : IEntity
    {
        TEntity Add(TEntity t);
        void Update(TEntity t);
        int Count();
        void Delete(TEntity entity);
        TEntity Find(Expression<Func<TEntity, bool>> match);
        ICollection<TEntity> FindAll(Expression<Func<TEntity, bool>> match);
        IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);
        TEntity Get(int id);
        IQueryable<TEntity> GetAll();
    }
}