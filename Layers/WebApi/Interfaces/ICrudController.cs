using Layers.Application.Interfaces;
using Layers.Domain.Interfaces.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Layers.WebApi.Interfaces
{
    public interface ICrudController<TViewModel, TEntity, TId>
        where TViewModel : IViewModel<TId>
        where TEntity : IEntity<TId>
        where TId : struct
    {
        IActionResult GetAll();

        IActionResult GetById(int id);

        void Add(TViewModel t);

        void Update(TViewModel value);

        void Remove(TViewModel entity);
    }
}