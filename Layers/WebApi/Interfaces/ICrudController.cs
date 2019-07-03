using Layers.Application.Interfaces;
using Layers.Domain.Interfaces.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Layers.WebApi.Interfaces
{
    public interface ICrudController<TEntity, TViewModel>
        where TEntity : IEntity
        where TViewModel : IViewModel
    {
        IActionResult Get();

        IActionResult GetById(int id);

        void Post(TViewModel t);

        void Put(TViewModel value);

        void Delete(TViewModel entity);
    }
}