using AutoMapper;
using RhDomain.Dto;
using RhDomain.Entities.Candidatos;
using RhDomain.Entities.Tecnologias;
using RhDomain.Entities.Vagas;
using RhDomain.Entities.VagasTecnologias;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {
            CreateMap<Candidato, CandidatoDto>();
            CreateMap<Vaga, VagaDto>();
            CreateMap<Tecnologia, TecnologiaDto>();
            CreateMap<VagaTecnologia, VagaTecnologiaDto>();
        }
    }
}
