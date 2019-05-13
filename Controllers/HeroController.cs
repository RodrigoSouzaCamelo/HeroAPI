using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HeroAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace HeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : ControllerBase
    {
        private readonly HeroDbContext _context;

        public HeroController(HeroDbContext context){
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.hero.ToList());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_context.hero.Where(h => h.Id == id));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Hero hero)
        {
            _context.hero.Add(hero);
            _context.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Hero value)
        {
            _context.Update(value);
            _context.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Hero hero = _context.hero.Where(h => h.Id == id).FirstOrDefault();
            _context.Remove(hero);
        }
    }
}
