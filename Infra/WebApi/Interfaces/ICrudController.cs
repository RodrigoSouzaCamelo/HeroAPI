using HeroAPI.Infra.Domain.Interfaces.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HeroAPI.Infra.WebApi.Interfaces
{
    public interface ICrudController<TEntity> where TEntity : IEntity
    {
        IActionResult Get();

        IActionResult GetById(int id);

        void Post(TEntity t);

        void Put(TEntity value);

        void Delete(TEntity entity);
    }
}