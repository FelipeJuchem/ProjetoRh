using AutoMapper;
using RhDomain.Dto;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RhDomain.Services.CandidatoTecnologiaServices
{
    public class CandidatoTecnologiaConsulta : ICandidatoTecnologiaConsulta
    {
        private readonly ICandidatoTecnologiaRepository _candidatoTecnologiaRepository;
        private readonly IMapper _mapper;
        public CandidatoTecnologiaConsulta(ICandidatoTecnologiaRepository candidatoTecnologiaRepository, IMapper mapper)
        {
            _candidatoTecnologiaRepository = candidatoTecnologiaRepository;
            _mapper = mapper;
        }

        public async Task<List<CandidatoTecnologiaDto>> BuscarListaCandidatoTecnologia()
        {
            var listaCandidatoTecnologia = await _candidatoTecnologiaRepository.BuscarLista();
            var listaCandidatoTecnologiaDto = _mapper.Map<List<CandidatoTecnologiaDto>>(listaCandidatoTecnologia);
            return listaCandidatoTecnologiaDto;
        }

        public CandidatoTecnologiaDto BuscarPorIdDuplo(int candidatoId, int TecnologiaId)
        {
            var candidatoTecnologia = _candidatoTecnologiaRepository.BuscarCandidatoTecnologiaporDuploId(candidatoId, TecnologiaId);
            var candidatoTecnologiaDto = _mapper.Map<CandidatoTecnologiaDto>(candidatoTecnologia);
            return candidatoTecnologiaDto;
        }

        
    }
}
