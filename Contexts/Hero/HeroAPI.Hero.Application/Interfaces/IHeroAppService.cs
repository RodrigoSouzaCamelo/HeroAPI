using HeroAPI.Application.ViewModels;
using HeroAPI.Hero.Domain.Entities;
using Layers.Application.Interfaces;

namespace HeroAPI.Application.Interfaces{
    public interface IHeroAppService : IBaseAppService<HeroEntity, HeroViewModel>
    {        
    }
}