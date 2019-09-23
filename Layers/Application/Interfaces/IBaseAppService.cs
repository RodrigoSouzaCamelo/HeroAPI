using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Layers.Domain.Interfaces.Entities;

namespace Layers.Application.Interfaces
{
    public interface IBaseAppService<TViewModel, TEntity, TId> 
        where TEntity : IEntity<TId>
        where TViewModel : IViewModel<TId>
        where TId : struct
    {
        TViewModel GetAll(int id);
        IEnumerable<TViewModel> GetAll();
        TViewModel Add(TViewModel viewModel);
        void Update(TViewModel viewModel);
        void Remove(TViewModel entity);
        int Count();
        TViewModel Find(Expression<Func<TViewModel, bool>> match);
        ICollection<TViewModel> FindAll(Expression<Func<TViewModel, bool>> match);
        IQueryable<TViewModel> FindBy(Expression<Func<TViewModel, bool>> predicate);
    }
}