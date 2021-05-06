using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RhData;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.UnitOfWork;
using System;

namespace RhIOC
{
    public static class Startup
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(options => options.UseSqlServer(configuration["ConnectionStrings:RHDatabase"]));
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
            services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));
                
        }
    }
    
}
