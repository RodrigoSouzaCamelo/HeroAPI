using AutoMapper;
using HeroAPI.Data.Entities;
using HeroAPI.Data.Models;

namespace HeroAPI.Data.Mappings{
    public class MappingProfile : Profile {
        public MappingProfile(){
            CreateMap<Hero, HeroModel>()
                .ReverseMap();
        }
    }
}