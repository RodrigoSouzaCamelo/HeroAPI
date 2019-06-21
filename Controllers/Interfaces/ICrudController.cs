using HeroAPI.Data.Entities.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HeroAPI.Controllers.Interfaces
{
    public interface ICrudController<TEntity, TModel, TId>
    where TEntity : IEntity<TId>
    {
        IActionResult Get();
        IActionResult GetById(TId id);
        void Post(TModel model);
        void Put(TModel model);
        void Delete(TId id);
    }
}