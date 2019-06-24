using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using HeroAPI.Data.Entities.Interfaces;
using HeroAPI.Data.Models.Interfaces;
using HeroAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HeroAPI.Services{
    public class Service<TEntity, TModel, TId> : IService<TEntity, TModel, TId>
    where TEntity : class, IEntity<TId>
    where TModel : IViewModel<TId>
    //where TId : struct
    {
        public readonly DbContext _dbContext;
        public readonly IMapper _mapper;

        public Service(IMapper mapper, DbContext dbContext){
            _mapper = mapper;
            _dbContext = dbContext;
        }
        public void Create(TModel model)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(TId id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TModel> GetAll()
        {
            IQueryable<TEntity> entities = _dbContext.Set<TEntity>();
            return _mapper.Map<IEnumerable<TModel>>(entities.AsEnumerable());
        }

        public TModel GetById(TId id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(TModel model)
        {
            throw new System.NotImplementedException();
        }
    }
}