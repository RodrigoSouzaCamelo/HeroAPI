using AutoMapper;
using HeroAPI.Infra.Application.Interfaces;
using HeroAPI.Infra.Domain.Interfaces.Entities;

namespace HeroAPI.Infra.Application.Mappings
{
    public class MappingProfile<TEntity, TViewModel> : Profile
    where TEntity : IEntity
    where TViewModel : IViewModel
    {
        public MappingProfile()
        {
            CreateMap<TEntity, TViewModel>()
                .ReverseMap();
        }
    }
}