using AutoMapper;
using HeroAPI.Application.Interfaces;
using HeroAPI.Application.ViewModels;
using HeroAPI.Infra.Data.Interfaces;
using HeroAPI.Infra.Application.AppServices;
using HeroAPI.Domain.Interfaces;
using HeroAPI.Domain.Entities;

namespace HeroAPI.Application.AppServices
{
    public class HeroAppService : BaseAppService<Hero, HeroViewModel>, IHeroAppService
    {
        public HeroAppService(IMapper mapper, IHeroRepository repository) : base(mapper, repository)
        {
        }
    }
}