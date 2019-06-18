using HeroAPI.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace HeroAPI.Data.Contexts
{
    public class HeroDbContext : DbContext
    {
        public HeroDbContext(DbContextOptions<HeroDbContext> option) : base(option) { }

        public DbSet<Hero> hero { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hero>()
                .ToTable("Heroes");

            base.OnModelCreating(modelBuilder);
        }
    }
}