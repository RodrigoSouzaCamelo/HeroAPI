using System.Linq;
using HeroAPI.Data.Contexts;
using HeroAPI.Data.Entities;
using HeroAPI.Data.Models;
using HeroAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : CrudController<Hero, HeroModel, int>
    {
        public HeroController(IService<Hero, HeroModel, int> service) : base(service)
        {
        }
    }
}
