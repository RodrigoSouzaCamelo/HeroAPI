using AutoMapper;
using Layers.Application.Interfaces;
using Layers.Domain.Interfaces.Entities;

namespace Layers.Application.Mappings
{
    public class MappingProfile<TViewModel, TEntity, TId> : Profile
        where TViewModel : IViewModel<TId>
        where TEntity : IEntity<TId>
        where TId : struct
    {
        public MappingProfile()
        {
        }
    }
}