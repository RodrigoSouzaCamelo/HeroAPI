using HeroAPI.Hero.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HeroAPI.Infra{
    public class HeroAPIContext : DbContext{
        public HeroAPIContext(DbContextOptions<HeroAPIContext> option) : base(option) { }

        public DbSet<HeroEntity> hero { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroEntity>()
                .ToTable("Heroes");

            base.OnModelCreating(modelBuilder);
        }
    }
}