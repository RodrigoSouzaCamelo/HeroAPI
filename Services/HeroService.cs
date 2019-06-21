using AutoMapper;
using HeroAPI.Data.Contexts;
using HeroAPI.Data.Entities;
using HeroAPI.Data.Models;
using HeroAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HeroAPI.Services{
    public class HeroService : Service<Hero, HeroModel, int>, IHeroService
    {
        public HeroService(IMapper mapper, HeroDbContext dbContext) : base(mapper, dbContext)
        {
        }
    }
}