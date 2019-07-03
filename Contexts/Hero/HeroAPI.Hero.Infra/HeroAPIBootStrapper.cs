using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace HeroAPI.Infra
{
    public static class HeroAPIBootStrapper
    {
        public static void AddHeroContext(this IServiceCollection services)
        {
            // other service configurations go here
            services.AddDbContextPool<HeroAPIContext>( // replace "YourDbContext" with the class name of your DbContext
                options => options.UseMySql("Server=localhost;Database=HeroAPI;User=root;Password=qwe123*;", // replace with your Connection String
                    mySqlOptions =>
                    {
                        mySqlOptions.ServerVersion(new Version(10, 1, 38), ServerType.MySql); // replace with your Server Version and Type
                    }
                ));
        }
    }
}