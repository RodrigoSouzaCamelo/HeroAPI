using AutoMapper;
using HeroAPI.Application.Interfaces;
using HeroAPI.Application.ViewModels;
using HeroAPI.Domain.Interfaces;
using HeroAPI.Domain.Entities;
using Layers.Application.AppServices;

namespace HeroAPI.Application.AppServices
{
    public class HeroAppService : BaseAppService<Hero, HeroViewModel>, IHeroAppService
    {
        public HeroAppService(IMapper mapper, IHeroRepository repository) : base(mapper, repository)
        {
        }
    }
}