using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RhData;
using RhData.Repositories;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services;
using RhDomain.Interfaces.Services.CandidatoValidationInterface;
using RhDomain.Interfaces.Services.VagaValidationInterface;
using RhDomain.Interfaces.UnitOfWork;
using RhDomain.Services.CandidatoServices;
using RhDomain.Services.CandidatoValidations;
using RhDomain.Services.VagaServices;
using RhDomain.Services.VagasValidation;
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
            services.AddScoped(typeof(ICandidatoConsulta), typeof(CandidatoConsulta));
            services.AddScoped(typeof(ICandidatoRepository), typeof(CandidatoRepository));
            services.AddScoped(typeof(IVagaRepository), typeof(VagaRepository));
            services.AddScoped(typeof(IVagaTecnologiaRepository), typeof(VagaTecnologiaRepository));
            services.AddScoped(typeof(ICandidatoArmazenador), typeof(CandidatoArmazenador));
            services.AddScoped(typeof(ICandidatoValidation), typeof(CandidatoValidation));
            services.AddScoped(typeof(ICandidatoExcluidor), typeof(CandidatoExcluidor));
            services.AddScoped(typeof(IVagaArmazenador), typeof(VagaArmazenador));
            services.AddScoped(typeof(IVagaValidation), typeof(VagaValidation));
            services.AddScoped(typeof(IVagaConsulta), typeof(VagaConsulta));
        }
    }
    
}
