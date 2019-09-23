
using HeroAPI.Hero.Domain.Entities;
using HeroAPI.Hero.Domain.Interfaces;
using HeroAPI.Infra;
using Layers.Data.Repositories;

namespace HeroAPI.Data.Repositories{
    public class HeroRepository : BaseRepository<HeroEntity, int>, IHeroRepository
    {
        public HeroRepository(HeroAPIContext context) : base(context)
        {
        }
    }
}