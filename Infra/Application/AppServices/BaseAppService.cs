using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using HeroAPI.Application.Interfaces;
using HeroAPI.Infra.Data.Interfaces;
using HeroAPI.Infra.Application.Interfaces;

namespace HeroAPI.Infra.Application.AppServices
{
    public abstract class BaseAppService<T> : IBaseAppService<T> where T : class
    {

        protected IBaseRepository<T> _repository;

        public BaseAppService(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        public T Add(T t)
        {
            _repository.Add(t);
            return t;
        }

        public void Update(T t)
        {
            _repository.Update(t);
        }

        public int Count()
        {
            return _repository.Count();
        }

        public void Delete(T entity)
        {
            _repository.Delete(entity);
        }

        public T Find(Expression<Func<T, bool>> match)
        {
            return _repository.Find(match);
        }

        public ICollection<T> FindAll(Expression<Func<T, bool>> match)
        {
            return _repository.FindAll(match);
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _repository.FindBy(predicate);
        }

        public T Get(int id)
        {
            return _repository.Get(id);
        }

        public IQueryable<T> GetAll()
        {
            return _repository.GetAll();
        }
    }
}