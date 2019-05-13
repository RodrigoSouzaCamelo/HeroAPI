using Microsoft.AspNetCore.Mvc;

namespace HeroAPI.Infra.WebApi.Interfaces
{
    public interface ICrudController<T> where T : class
    {
        IActionResult Get();

        ActionResult<T> Get(int id);

        void Post([FromBody] T t);

        void Put([FromBody] T value);

        void Delete(T entity);
    }
}