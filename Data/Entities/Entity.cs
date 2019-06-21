using HeroAPI.Data.Entities.Interfaces;

namespace HeroAPI.Data.Entities
{
    public class Entity<TId> : IEntity<TId>
    {
        public TId id { get; set; }
    }
}