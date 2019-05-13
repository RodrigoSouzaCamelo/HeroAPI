using HeroAPI.Application.Interfaces;
using HeroAPI.Infra.Data.Interfaces;
using HeroAPI.Infra.Application.AppServices;
using HeroAPI.Domain.Interfaces;

namespace HeroAPI.Application.AppServices
{
    public class HeroAppService : BaseAppService<IHeroRepository>, IHeroAppService
    {
        public HeroAppService(IBaseRepository<IHeroRepository> repository) : base(repository)
        {
        }
    }
}