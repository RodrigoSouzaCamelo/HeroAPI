using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Layers.Domain.Interfaces.Entities;

namespace Layers.Application.Interfaces
{
    public interface IBaseAppService<TEntity, TViewModel> 
        where TEntity : IEntity
        where TViewModel : IViewModel
    {
        TViewModel Add(TViewModel t);
        void Update(TViewModel t);
        int Count();
        void Delete(TViewModel entity);
        TViewModel Find(Expression<Func<TViewModel, bool>> match);
        ICollection<TViewModel> FindAll(Expression<Func<TViewModel, bool>> match);
        IQueryable<TViewModel> FindBy(Expression<Func<TViewModel, bool>> predicate);
        TViewModel Get(int id);
        IEnumerable<TViewModel> GetAll();
    }
}