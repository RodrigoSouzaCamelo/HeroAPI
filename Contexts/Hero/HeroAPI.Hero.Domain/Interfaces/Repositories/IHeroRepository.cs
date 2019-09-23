using Layers.Data.Interfaces;
using HeroAPI.Hero.Domain.Entities;

namespace HeroAPI.Hero.Domain.Interfaces{
    public interface IHeroRepository : IBaseRepository<HeroEntity, int>
    {
        
    }
}