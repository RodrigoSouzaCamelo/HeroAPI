using HeroAPI.Data.Entities;
using HeroAPI.Data.Models;

namespace HeroAPI.Services.Interfaces
{
    public interface IHeroService : IService<Hero, HeroModel, int>
    {}
}