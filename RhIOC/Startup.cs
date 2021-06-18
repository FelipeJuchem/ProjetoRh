using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RhData;
using RhData.Repositories;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services;
using RhDomain.Interfaces.Services.CandidatoTecnologiaValidations;
using RhDomain.Interfaces.Services.CandidatoValidationInterface;
using RhDomain.Interfaces.Services.TecnologiaValidation;
using RhDomain.Interfaces.Services.VagaValidationInterface;
using RhDomain.Interfaces.UnitOfWork;
using RhDomain.Services.CandidatoServices;
using RhDomain.Services.CandidatoTecnologiaServices;
using RhDomain.Services.CandidatoTecnologiaValidation;
using RhDomain.Services.CandidatoValidations;
using RhDomain.Services.TecnologiaServices;
using RhDomain.Services.TecnologiaValidations;
using RhDomain.Services.VagaServices;
using RhDomain.Services.VagasValidation;
using RhDomain.Services.VagaTecnologiaServices;
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
            services.AddScoped(typeof(IVagaAlterador), typeof(VagaAlterador));
            services.AddScoped(typeof(IVagaExcluidor), typeof(VagaExcluidor));
            services.AddScoped(typeof(ICandidatoAlterador), typeof(CandidatoAlterador));
            services.AddScoped(typeof(ITecnologiaValidation), typeof(TecnologiaValidation));
            services.AddScoped(typeof(ITecnologiaArmazenador), typeof(TecnologiaArmazenador));
            services.AddScoped(typeof(ITecnologiaConsulta), typeof(TecnologiaConsulta));
            services.AddScoped(typeof(ITecnologiaRepository), typeof(TecnologiaRepository));
            services.AddScoped(typeof(ITecnologiaExcluidor), typeof(TecnologiaExcluidor));
            services.AddScoped(typeof(ITecnologiaAlterador), typeof(TecnologiaAlterador));
            services.AddScoped(typeof(IVagaTecnologiaArmazenador), typeof(VagaTecnologiaArmazenador));
            services.AddScoped(typeof(IVagaTecnologiaConsulta), typeof(VagaTecnologiaConsulta));
            services.AddScoped(typeof(IVagaTecnologiaExcluidor), typeof(VagaTecnologiaExcluidor));
            services.AddScoped(typeof(ICandidatoTecnologiaRepository), typeof(CandidatoTecnologiaRepository));
            services.AddScoped(typeof(ICandidatoTecnologiaArmazenador), typeof(CandidatoTecnologiaArmazenador));
            services.AddScoped(typeof(ICandidatoTecnologiaConsulta), typeof(CandidatoTecnologiaConsulta));
            services.AddScoped(typeof(ICandidatoTecnologiaExcluidor), typeof(CandidatoTecnologiaExcluidor));
            services.AddScoped(typeof(ICandidatoTecnologiaValidations), typeof(CandidatoTecnologiaValidations));
            services.AddScoped(typeof(IPermitirExclusaoDeVagaTecnologia), typeof(PermitirExclusaoDeVagaTecnologia));
        }
    }
    
}
