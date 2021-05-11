using AutoMapper;
using RhDomain.Dto;
using RhDomain.Entities.Candidatos;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Services.CandidatoServices
{
    public class CandidatoConsulta : ICandidatoConsulta
    {
        private readonly IMapper _mapper;
        private readonly ICandidatoRepository _candidatoRepository;

        public CandidatoConsulta(ICandidatoRepository candidatoRepository, IMapper mapper)
        {
            _mapper = mapper;
            _candidatoRepository = candidatoRepository;
        }
        public List<CandidatoDto> ObterListaCandidatos()
        {
            var listaCandidatos = _candidatoRepository.BuscarLista();
            var listaCandidatosDto = _mapper.Map<List<CandidatoDto>>(listaCandidatos);
            return listaCandidatosDto;
        }

        public CandidatoDto ObterPorId(int id)
        {
            var candidato = _candidatoRepository.BuscarPorId(id);
            var candidatoDto = _mapper.Map<CandidatoDto>(candidato);
            return candidatoDto;
        }


    }
}
