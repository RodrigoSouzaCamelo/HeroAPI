using HeroAPI.Data.Context;
using HeroAPI.Domain.Entities;
using HeroAPI.Domain.Interfaces;

namespace HeroAPI.Data.Repositories{
    public class HeroRepository : BaseRepository<Hero>, IHeroRepository
    {
        public HeroRepository(HeroDbContext context) : base(context)
        {
        }
    }
}