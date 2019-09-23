using Layers.Domain.Interfaces.Entities;

namespace Layers.Application.Interfaces
{
    public interface IViewModel<TId> : IEntity<TId>
        where TId : struct
    {
    }
}