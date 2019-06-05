using HeroAPI.Application.Interfaces;
using HeroAPI.Infra.Data.Interfaces;
using HeroAPI.Infra.Application.AppServices;
using HeroAPI.Domain.Interfaces;
using HeroAPI.Domain.Entities;

namespace HeroAPI.Application.AppServices
{
    public class HeroAppService : BaseAppService<Hero>, IHeroAppService
    {
        public HeroAppService(IBaseRepository<IHeroRepository> repository) : base(repository)
        {
        }
    }
}