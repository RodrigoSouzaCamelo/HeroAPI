namespace Layers.Domain.Interfaces.Entities
{
    public interface IEntity<TId>
        where TId : struct
    {
        TId Id { get; set; }
    }
}
