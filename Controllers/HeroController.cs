using HeroAPI.Application.Interfaces;
using HeroAPI.Application.ViewModels;
using HeroAPI.Domain.Entities;
using Layers.WebApi.Controller;
using Microsoft.AspNetCore.Mvc;

namespace HeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : CrudController<Hero, HeroViewModel>
    {
        public HeroController(IHeroAppService appService) : base(appService)
        {
        }
    }
}
