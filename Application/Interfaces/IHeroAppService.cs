using HeroAPI.Application.ViewModels;
using HeroAPI.Domain.Entities;
using HeroAPI.Infra.Application.Interfaces;

namespace HeroAPI.Application.Interfaces{
    public interface IHeroAppService : IBaseAppService<Hero, HeroViewModel>
    {        
    }
}