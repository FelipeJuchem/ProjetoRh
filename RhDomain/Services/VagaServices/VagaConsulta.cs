using AutoMapper;
using RhDomain.Dto;
using RhDomain.Entities.Tecnologias;
using RhDomain.Entities.Vagas;
using RhDomain.Entities.VagasTecnologias;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhDomain.Services.VagaServices
{
    public class VagaConsulta : IVagaConsulta
    {
        
        private readonly IMapper _mapper;
        private readonly IVagaRepository _vagaRepository;
        public VagaConsulta(IVagaRepository vagaRepository, IMapper mapper)
        {
            _mapper = mapper; 
            _vagaRepository = vagaRepository;
        }
        public async Task<List<VagaComTecnologiaECandidatosDto>> ObterListaDeVagas()
        {
            var listaVaga = await _vagaRepository.BuscarLista();
            var listaVagaDto = _mapper.Map<List<VagaComTecnologiaECandidatosDto>>(listaVaga);
            return listaVagaDto;
        }

        public VagaComTecnologiaECandidatosDto ObterVagaComTecnologiaPorId(int id)
        {
            var vaga = _vagaRepository.BuscaVagaComInclude(id);
            return  _mapper.Map<VagaComTecnologiaECandidatosDto>(vaga);
        }

        public VagaComCandidatoDtoSorteado ObterVagaComCandidatoSorteadoPorId(int id)
        {
            var vaga = _vagaRepository.BuscaVagaComInclude(id);
            _mapper.Map<List<CandidatoComTecnologiaDto>>(vaga.Candidatos);
            var vagaDto = _mapper.Map<VagaComCandidatoDtoSorteado>(vaga);
            foreach(var candidatoDto in vagaDto.Candidatos)
            {
                foreach(var tecnologia in candidatoDto.Tecnologias)
                {
                    candidatoDto.Pontuacao += tecnologia.Peso;
                }
            }
            var candidatosSorteados = vagaDto.Candidatos.OrderByDescending(x => x.Pontuacao).ToList();
            vagaDto.Candidatos = candidatosSorteados;
            return vagaDto;
        }

        public VagaDto ObterVagaPorId(int id)
        {
            var vaga = _vagaRepository.BuscarPorId(id);
            return _mapper.Map<VagaDto>(vaga);
        }
    }
}
