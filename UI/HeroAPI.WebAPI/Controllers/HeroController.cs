using HeroAPI.Application.Interfaces;
using HeroAPI.Application.ViewModels;
using HeroAPI.Hero.Domain.Entities;
using Layers.WebApi.Controller;
using Microsoft.AspNetCore.Mvc;

namespace HeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : CrudController<HeroEntity, HeroViewModel>
    {
        public HeroController(IHeroAppService appService) : base(appService)
        {
        }
    }
}
