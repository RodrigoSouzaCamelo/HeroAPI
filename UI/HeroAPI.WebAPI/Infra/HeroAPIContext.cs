using HeroAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HeroAPI.Infra{
    public class HeroAPIContext : DbContext{
        public HeroAPIContext(DbContextOptions<HeroAPIContext> option) : base(option) { }

        public DbSet<Hero> hero { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hero>()
                .ToTable("Heroes");

            base.OnModelCreating(modelBuilder);
        }
    }
}