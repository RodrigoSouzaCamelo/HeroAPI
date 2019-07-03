using HeroAPI.Domain.Entities;
using HeroAPI.Domain.Interfaces;
using HeroAPI.Infra;
using Layers.Data.Repositories;

namespace HeroAPI.Data.Repositories{
    public class HeroRepository : BaseRepository<Hero>, IHeroRepository
    {
        public HeroRepository(HeroAPIContext context) : base(context)
        {
        }
    }
}