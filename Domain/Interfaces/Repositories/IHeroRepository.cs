using HeroAPI.Domain.Entities;
using HeroAPI.Infra.Data.Interfaces;

namespace HeroAPI.Domain.Interfaces{
    public interface IHeroRepository : IBaseRepository<Hero>
    {
        
    }
}