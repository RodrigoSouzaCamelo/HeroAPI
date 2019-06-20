using HeroAPI.Infra.Application.Interfaces;
using HeroAPI.Infra.Domain.Interfaces.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HeroAPI.Infra.WebApi.Interfaces
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