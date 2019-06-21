using HeroAPI.Controllers.Interfaces;
using HeroAPI.Data.Entities.Interfaces;
using HeroAPI.Data.Models.Interfaces;
using HeroAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HeroAPI.Controllers
{
    public class CrudController<TEntity, TModel, TId> : ControllerBase, ICrudController<TEntity, TModel, TId>
    where TEntity : class, IEntity<TId>
    where TModel : IViewModel<TId>
    {
        private readonly IService<TEntity, TModel, TId> _service;

        public CrudController(IService<TEntity, TModel, TId> service) => _service = service;

        [HttpGet]
        public IActionResult Get() => Ok(_service.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(TId id) => Ok(_service.GetById(id));

        [HttpPost]
        public void Post([FromBody]TModel model) => _service.Create(model);

        [HttpPut]
        public void Put([FromBody]TModel model) => _service.Update(model);

        [HttpDelete("{id}")]
        public void Delete(TId id) => _service.Delete(id);
    }
}