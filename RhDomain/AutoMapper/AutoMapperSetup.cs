using AutoMapper;
using RhDomain.Dto;
using RhDomain.Entities.Candidatos;
using RhDomain.Entities.CandidatosTecnologias;
using RhDomain.Entities.Tecnologias;
using RhDomain.Entities.Vagas;
using RhDomain.Entities.VagasTecnologias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RhDomain.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            CreateMap<Candidato, CandidatoComTecnologiaParaArmazenarDto>()
                .ForMember(x => x.CandidatoId, y => y.MapFrom(t => t.Id))
                .ForMember(x => x.VagaId, y => y.MapFrom(t => t.VagaId))
                .ForMember(x => x.TecnologiaId, y => y.MapFrom(t => t.Vaga.VagasTecnologias.FirstOrDefault().TecnologiaId))
                .ForMember(x => x.Peso, y => y.MapFrom(t => t.Vaga.VagasTecnologias.FirstOrDefault().Peso));


            CreateMap<Candidato, CandidatoDto>()
                .ForMember(x => x.VagaDescricao, y => y.MapFrom(t => t.Vaga.Descricao));



            CreateMap<Candidato, CandidatoComTecnologiaDto>()
                .ForMember(x => x.Tecnologias, y => y.MapFrom(t => t.CandidatosTecnologias
                .Select(o => new TecnologiaDto()
                { Descricao = o.Tecnologia.Descricao, Id = o.Tecnologia.Id, Peso = o.Peso })));
                
                
            CreateMap<Vaga, VagaComTecnologiaECandidatosDto>()
                .ForMember(x => x.Tecnologias, y => y.MapFrom(t => t.VagasTecnologias
                .Select(o => new TecnologiaDto()
                { Descricao = o.Tecnologia.Descricao, Id = o.Tecnologia.Id, Peso = o.Peso })))
                .ForMember(x => x.Candidatos, y => y.MapFrom(t => t.Candidatos));
            CreateMap<Vaga, VagaDto>();
            CreateMap<Tecnologia, TecnologiaDto>()
                .ForMember(x => x.Peso, y => y.MapFrom(o => o.VagasTecnologias.FirstOrDefault().Peso));
            CreateMap<VagaTecnologia, VagaTecnologiaDto>();
            CreateMap<CandidatoTecnologia, CandidatoTecnologiaDto>()
                .ForMember(x => x.Peso, y => y.MapFrom(o => o.Tecnologia.VagasTecnologias.FirstOrDefault().Peso));

            
                
                
            
            //CreateMap<TecnologiaDto, VagaTecnologia>()
            //    .ForMember(x => x.Tecnologia.Id, y => y.MapFrom(t => t.Id))
            //    .ForMember(x => x.Tecnologia.Descricao, y => y.MapFrom(t => t.Descricao))
            //    .ForMember(x => x.Peso, y => y.MapFrom(t => t.Peso));

        }
    }
}
