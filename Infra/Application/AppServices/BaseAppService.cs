using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AutoMapper;
using HeroAPI.Application.Interfaces;
using HeroAPI.Infra.Data.Interfaces;
using HeroAPI.Infra.Application.Interfaces;
using HeroAPI.Infra.Domain.Interfaces.Entities;

namespace HeroAPI.Infra.Application.AppServices
{
    public class BaseAppService<TEntity, TViewModel> : IBaseAppService<TEntity, TViewModel> 
        where TEntity : IEntity
        where TViewModel : IViewModel
    {

        protected IBaseRepository<TEntity> _repository;
        protected IMapper _mapper;

        public BaseAppService(IMapper mapper, IBaseRepository<TEntity> repository)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public TViewModel Add(TViewModel viewModel)
        {
            var entity = _mapper.Map<TEntity>(viewModel);
            _repository.Add(entity);
            return viewModel;
        }

        public void Update(TViewModel viewModel)
        {
            var entity = _mapper.Map<TEntity>(viewModel);
            _repository.Update(entity);
        }

        public int Count()
        {
            return _repository.Count();
        }

        public void Delete(TViewModel viewModel)
        {
            var entity = _mapper.Map<TEntity>(viewModel);
            _repository.Delete(entity);
        }

        public TViewModel Find(Expression<Func<TViewModel, bool>> expressionVM)
        {
            var param = Expression.Parameter(typeof(TEntity));
            var body = expressionVM.Body;
            
            Expression<Func<TEntity, bool>> lambda = Expression.Lambda<Func<TEntity, bool>>(body, param);
            TEntity entity = _repository.Find(lambda);
            TViewModel viewModel = _mapper.Map<TViewModel>(entity);

            return viewModel;
        }

        public ICollection<TViewModel> FindAll(Expression<Func<TViewModel, bool>> expressionVM)
        {
            var param = Expression.Parameter(typeof(TEntity));
            var body = expressionVM.Body;
            
            Expression<Func<TEntity, bool>> lambda = Expression.Lambda<Func<TEntity, bool>>(body, param);
            ICollection<TEntity> entities = _repository.FindAll(lambda);
            ICollection<TViewModel> viewModels = _mapper.Map<ICollection<TViewModel>>(entities);

            return viewModels;
        }

        public IQueryable<TViewModel> FindBy(Expression<Func<TViewModel, bool>> expressionVM)
        {
            var param = Expression.Parameter(typeof(TEntity));
            var body = expressionVM.Body;
            
            Expression<Func<TEntity, bool>> lambda = Expression.Lambda<Func<TEntity, bool>>(body, param);
            IQueryable<TEntity> entities = _repository.FindBy(lambda);
            IQueryable<TViewModel> viewModels = _mapper.Map<IQueryable<TViewModel>>(entities);

            return viewModels;
        }

        public TViewModel Get(int id)
        {
            var entity = _repository.Get(id);
            return _mapper.Map<TViewModel>(entity);
        }

        public IEnumerable<TViewModel> GetAll()
        {
            var entities = _repository.GetAll();
            return _mapper.Map<IEnumerable<TEntity>, IEnumerable<TViewModel>>(entities.AsEnumerable());
        }
    }
}