using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using HeroAPI.Application.Interfaces;
using HeroAPI.Infra.Data.Interfaces;
using HeroAPI.Infra.Application.Interfaces;
using HeroAPI.Infra.Domain.Interfaces.Entities;

namespace HeroAPI.Infra.Application.AppServices
{
    public class BaseAppService<TEntity> : IBaseAppService<TEntity> where TEntity : IEntity
    {

        protected IBaseRepository<TEntity> _repository;

        public BaseAppService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public TEntity Add(TEntity t)
        {
            _repository.Add(t);
            return t;
        }

        public void Update(TEntity t)
        {
            _repository.Update(t);
        }

        public int Count()
        {
            return _repository.Count();
        }

        public void Delete(TEntity entity)
        {
            _repository.Delete(entity);
        }

        public TEntity Find(Expression<Func<TEntity, bool>> match)
        {
            return _repository.Find(match);
        }

        public ICollection<TEntity> FindAll(Expression<Func<TEntity, bool>> match)
        {
            return _repository.FindAll(match);
        }

        public IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            return _repository.FindBy(predicate);
        }

        public TEntity Get(int id)
        {
            return _repository.Get(id);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }
    }
}