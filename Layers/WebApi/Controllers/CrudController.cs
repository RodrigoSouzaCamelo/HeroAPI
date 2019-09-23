using Layers.Application.Interfaces;
using Layers.Domain.Interfaces.Entities;
using Layers.WebApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Layers.WebApi.Controller
{
    public class CrudController<TViewModel, TEntity, TId> : ControllerBase, ICrudController<TViewModel, TEntity, TId> 
        where TEntity : IEntity<TId>
        where TViewModel : IViewModel<TId>
        where TId : struct
    {
        protected readonly IBaseAppService<TViewModel, TEntity, TId> _appService;
        
        public CrudController(IBaseAppService<TViewModel, TEntity, TId> appService)
            => _appService = appService;

        // GET api/controller
        [HttpGet]
        public IActionResult GetAll() => Ok(_appService.GetAll());

        // GET api/controller/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id) => Ok(_appService.GetAll(id));

        // POST api/controller
        [HttpPost("Add")]
        public void Add([FromBody] TViewModel viewModel) => _appService.Add(viewModel);

        // PUT api/controller/5
        [HttpPut("Update")]
        public void Update([FromBody] TViewModel viewModel) => _appService.Update(viewModel);

        // DELETE api/controller/5
        [HttpDelete("Remove")]
        public void Remove([FromBody]TViewModel entity) => _appService.Remove(entity);
    }
}