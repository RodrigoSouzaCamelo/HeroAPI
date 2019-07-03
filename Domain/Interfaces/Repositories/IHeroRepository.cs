using HeroAPI.Domain.Entities;
using Layers.Data.Interfaces;

namespace HeroAPI.Domain.Interfaces{
    public interface IHeroRepository : IBaseRepository<Hero>
    {
        
    }
}