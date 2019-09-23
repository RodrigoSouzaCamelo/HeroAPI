using Layers.Application.Interfaces;

namespace Layers.Application.ViewModels
{
    public class ViewModel<TId> : IViewModel<TId>
        where TId : struct
    {
        public TId Id { get; set; }
    }
}