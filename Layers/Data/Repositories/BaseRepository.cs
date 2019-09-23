using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Layers.Data.Interfaces;
using Layers.Domain.Interfaces.Entities;
using Microsoft.EntityFrameworkCore;

namespace Layers.Data.Repositories
{
    public abstract class BaseRepository<TEntity, TId> : IBaseRepository<TEntity, TId>
        where TEntity : class, IEntity<TId>
        where TId : struct
    {
        protected DbContext _context;

        public BaseRepository(DbContext context) => _context = context;

        public IQueryable<TEntity> GetAll() => _context.Set<TEntity>();

        public virtual TEntity GetById(int id) => _context.Set<TEntity>().Find(id);

        public virtual TEntity Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public virtual TEntity Find(Expression<Func<TEntity, bool>> match)
            => _context.Set<TEntity>().SingleOrDefault(match);

        public ICollection<TEntity> FindAll(Expression<Func<TEntity, bool>> match)
            => _context.Set<TEntity>().Where(match).ToList();

        public virtual void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }

        public virtual TEntity Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();
            return entity;
        }

        public int Count() => _context.Set<TEntity>().Count();

        public virtual void Save() => _context.SaveChanges();

        public virtual IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>().Where(predicate);
            return query;
        }

        public IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] includeProperties)
        {

            IQueryable<TEntity> queryable = GetAll();
            foreach (Expression<Func<TEntity, object>> includeProperty in includeProperties)
            {

                queryable = queryable.Include<TEntity, object>(includeProperty);
            }

            return queryable;
        }


        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public virtual TEntity UpdateKey(TEntity t, object key)
        {
            if (t == null)
                return null;
            TEntity exist = _context.Set<TEntity>().Find(key);

            if (exist != null)
            {
                _context.Entry(exist).CurrentValues.SetValues(t);
                _context.SaveChanges();
            }
            return exist;
        }

    }
}