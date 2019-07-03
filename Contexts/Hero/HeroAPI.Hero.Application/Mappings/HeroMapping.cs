using HeroAPI.Application.ViewModels;
using HeroAPI.Hero.Domain.Entities;
using Layers.Application.Mappings;

namespace HeroAPI.Application.Mappings
{
    public class HeroMapping : MappingProfile<HeroEntity, HeroViewModel>
    {
    }
}