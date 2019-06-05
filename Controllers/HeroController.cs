using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HeroAPI.Application.Interfaces;
using HeroAPI.Domain.Entities;
using HeroAPI.Infra.Application.Interfaces;
using HeroAPI.Infra.WebApi.Controller;
using Microsoft.AspNetCore.Mvc;

namespace HeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : CrudController<Hero>
    {
        public HeroController(IHeroAppService appService) : base(appService)
        {
        }
    }
}
