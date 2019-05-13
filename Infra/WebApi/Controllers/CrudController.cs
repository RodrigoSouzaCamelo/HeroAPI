using HeroAPI.Application.AppServices;
using HeroAPI.Application.Interfaces;
using HeroAPI.Infra.Application.Interfaces;
using HeroAPI.Infra.WebApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HeroAPI.Infra.WebApi.Controller
{
    public abstract class CrudController<T> : ControllerBase, ICrudController<T> where T : class
    {
        protected readonly IBaseAppService<T> _appService;
        
        public CrudController(IBaseAppService<T> appService)
        {
            _appService = appService;
        }

        // DELETE api/controller/5
        [HttpDelete("{id}")]
        public void Delete(T entity)
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
        public ActionResult<T> Get(int id)
        {
            return Ok(_appService.Get(id));
        }

        // POST api/controller
        [HttpPost]
        public void Post([FromBody] T t)
        {
            _appService.Add(t);
        }

        // PUT api/controller/5
        [HttpPut]
        public void Put([FromBody] T entity)
        {
            _appService.Update(entity);
        }
    }
}