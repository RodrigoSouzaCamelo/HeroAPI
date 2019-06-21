using System.Collections.Generic;
using HeroAPI.Data.Entities.Interfaces;
using HeroAPI.Data.Models.Interfaces;

namespace HeroAPI.Services.Interfaces
{
    public interface IService<TEntity, TModel, TId>
    where TEntity : class, IEntity<TId>
    where TModel : IViewModel<TId>
    {
        IEnumerable<TModel> GetAll();
        TModel GetById(TId id);
        void Create(TModel model);
        void Update(TModel model);
        void Delete(TId id);
     }
}