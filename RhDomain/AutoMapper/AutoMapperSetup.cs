using AutoMapper;
using RhDomain.Dto;
using RhDomain.Entities.Candidatos;
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
            CreateMap<Candidato, CandidatoDto>();
            CreateMap<Vaga, VagaComTecnologiaDto>()
                .ForMember(x => x.Tecnologias, y => y.MapFrom(t => t.VagasTecnologias
                .Select(o => new TecnologiaDto()
                { Descricao = o.Tecnologia.Descricao, Id = o.Tecnologia.Id, Peso = o.Peso })));
            CreateMap<Vaga, VagaDto>();
            CreateMap<Tecnologia, TecnologiaDto>();
            CreateMap<VagaTecnologia, VagaTecnologiaDto>();
            
            
            
            //CreateMap<TecnologiaDto, VagaTecnologia>()
            //    .ForMember(x => x.Tecnologia.Id, y => y.MapFrom(t => t.Id))
            //    .ForMember(x => x.Tecnologia.Descricao, y => y.MapFrom(t => t.Descricao))
            //    .ForMember(x => x.Peso, y => y.MapFrom(t => t.Peso));
                
        }
    }
}
