using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace HeroAPI.Infra.Application.Interfaces
{
    public interface IBaseAppService<T> where T : class
    {
        T Add(T t);
        void Update(T t);
        int Count();
        void Delete(T entity);
        T Find(Expression<Func<T, bool>> match);
        ICollection<T> FindAll(Expression<Func<T, bool>> match);
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        T Get(int id);
        IQueryable<T> GetAll();
    }
}