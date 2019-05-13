using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace HeroAPI.Infra.Data.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        T Add(T t);
        int Count();
        void Delete(T entity);
        void Dispose();
        T Find(Expression<Func<T, bool>> match);
        ICollection<T> FindAll(Expression<Func<T, bool>> match);
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        T Get(int id);
        IQueryable<T> GetAll();
        IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties);
        void Save();
        T Update(T t);
        T UpdateKey(T t, object key);

    }
}