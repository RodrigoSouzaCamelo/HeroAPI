using AutoMapper;
using Layers.Application.Interfaces;
using Layers.Domain.Interfaces.Entities;

namespace Layers.Application.Mappings
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