using AutoMapper;
using RhDomain.Dto;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public async Task<List<CandidatoDto>> ObterListaCandidatos()
        {
            var listaCandidatos = await _candidatoRepository.BuscarListaCandidatosComVagaDescricao();
            if(listaCandidatos.Count == 0)
            {
                throw new Exception("Não existe nenhum candidato cadastrado!");
            }
            var listaCandidatosDto = _mapper.Map<List<CandidatoDto>>(listaCandidatos);
            return listaCandidatosDto;
        }

        public CandidatoDto ObterPorId(int id)
        {
            var candidato = _candidatoRepository.BuscarPorId(id);
            if(candidato == null)
            {
                throw new Exception("Candidato não existe!");
            }
            var candidatoDto = _mapper.Map<CandidatoDto>(candidato);
            return candidatoDto;
        }

        public CandidatoComTecnologiaDto ObterCandidatoComTecnologia(int id)
        {
            var candidato = _candidatoRepository.BuscaCandidatoTecnologiaComTecnologias(id);
            var candidatoDto =  _mapper.Map<CandidatoComTecnologiaDto>(candidato);
            var candidatosSorteadosPorPesoDasTecnologias = candidatoDto.Tecnologias.OrderBy(x => x.Peso).ToList();
            candidatoDto.Tecnologias = candidatosSorteadosPorPesoDasTecnologias;
            return candidatoDto;
        }

        public CandidatoComTecnologiaParaArmazenarDto BuscarParaArmazenarCandidatoTecnologia(
            CandidatoComTecnologiaParaArmazenarDto candidatoComTecnologiaParaArmazenarDto)
        {
            var candidato = _candidatoRepository.BuscarParaArmazenarCandidatoTecnologia(candidatoComTecnologiaParaArmazenarDto);
            var candidatoDto = _mapper.Map<CandidatoComTecnologiaParaArmazenarDto>(candidato);
            return candidatoDto;
        }



    }
}
