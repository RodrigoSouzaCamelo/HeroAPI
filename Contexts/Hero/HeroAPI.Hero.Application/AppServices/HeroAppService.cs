using AutoMapper;
using HeroAPI.Application.Interfaces;
using HeroAPI.Application.ViewModels;
using HeroAPI.Hero.Domain.Entities;
using HeroAPI.Hero.Domain.Interfaces;
using Layers.Application.AppServices;

namespace HeroAPI.Application.AppServices
{
    public class HeroAppService : BaseAppService<HeroEntity, HeroViewModel>, IHeroAppService
    {
        public HeroAppService(IMapper mapper, IHeroRepository repository) : base(mapper, repository)
        {
        }
    }
}