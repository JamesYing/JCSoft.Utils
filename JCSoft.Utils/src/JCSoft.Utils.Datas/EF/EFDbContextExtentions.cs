using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace JCSoft.Utils.Datas.EF
{
    public static class EFDbContextExtentions 
    {
        public static void AddEfDbContext<TContext>(this IServiceCollection services, Action<EFDataOptions> action )
            where TContext : DbContext
        {
            var options = new EFDataOptions();
            action(options);

            services.AddDbContext<TContext>(o =>
            {
                ConfigurationDbContextBuild(o, options);
            });
        }

        private static void ConfigurationDbContextBuild(DbContextOptionsBuilder o, EFDataOptions options)
        {
            var build = EFDbContextBuilderFactory.CreateBuilder(options);
            build.Build(o, options);
        }
    }
}
