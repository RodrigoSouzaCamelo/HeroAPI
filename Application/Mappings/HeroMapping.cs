using AutoMapper;
using HeroAPI.Application.ViewModels;
using HeroAPI.Domain.Entities;
using HeroAPI.Infra.Application.Mappings;

namespace HeroAPI.Application.Mappings
{
    public class HeroMapping : MappingProfile<Hero, HeroViewModel>
    {
    }
}