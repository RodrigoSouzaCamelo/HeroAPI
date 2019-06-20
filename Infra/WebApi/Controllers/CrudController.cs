using HeroAPI.Application.AppServices;
using HeroAPI.Application.Interfaces;
using HeroAPI.Infra.Application.Interfaces;
using HeroAPI.Infra.Domain.Interfaces.Entities;
using HeroAPI.Infra.WebApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HeroAPI.Infra.WebApi.Controller
{
    public class CrudController<TEntity, TViewModel> : ControllerBase, ICrudController<TEntity, TViewModel> 
        where TEntity : IEntity
        where TViewModel : IViewModel
    {
        protected readonly IBaseAppService<TEntity, TViewModel> _appService;
        
        public CrudController(IBaseAppService<TEntity, TViewModel> appService)
        {
            _appService = appService;
        }

        // DELETE api/controller/5
        [HttpDelete("{id}")]
        public void Delete(TViewModel entity)
        {
            _appService.Delete(entity);
        }

        // GET api/controller
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_appService.GetAll());
        }

        // GET api/controller/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_appService.Get(id));
        }

        // POST api/controller
        [HttpPost]
        public void Post([FromBody] TViewModel t)
        {
            _appService.Add(t);
        }

        // PUT api/controller/5
        [HttpPut]
        public void Put([FromBody] TViewModel entity)
        {
            _appService.Update(entity);
        }
    }
}