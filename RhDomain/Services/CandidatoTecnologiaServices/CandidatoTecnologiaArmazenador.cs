using AutoMapper;
using RhDomain.Dto;
using RhDomain.Entities.CandidatosTecnologias;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services;
using RhDomain.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RhDomain.Services.CandidatoTecnologiaServices
{
    public class CandidatoTecnologiaArmazenador : ICandidatoTecnologiaArmazenador
    {
        private readonly ICandidatoRepository _candidatoRepository;
        private readonly IVagaTecnologiaRepository _vagaTecnologiaRepository;
        private readonly ICandidatoTecnologiaRepository _candidatoTecnologiaRepository;
        private readonly IUnitOfWork _uow;

        public CandidatoTecnologiaArmazenador(ICandidatoTecnologiaRepository candidatoTecnologiaRepository, IUnitOfWork uow,
            IVagaTecnologiaRepository vagaTecnologiaRepository, ICandidatoRepository candidatoRepository)
        {
            _candidatoRepository = candidatoRepository;
            _vagaTecnologiaRepository = vagaTecnologiaRepository;
            _candidatoTecnologiaRepository = candidatoTecnologiaRepository;
            _uow = uow;
        }

        public async Task<CandidatoTecnologiaDto> IncluirCandidatoTecnologia(CandidatoTecnologiaDto candidatoTecnologiaDto)
        {
            if (candidatoTecnologiaDto != null && candidatoTecnologiaDto.TecnologiaId != 0)
            {
                var candidato = _candidatoRepository.BuscarPorId(candidatoTecnologiaDto.CandidatoId);
                var vagaTecnologia = await _vagaTecnologiaRepository.BuscaVagaTecnologiaPorIdDuplo(candidato.VagaId, candidatoTecnologiaDto.TecnologiaId);
                var candidatoTecnologia = new CandidatoTecnologia(candidatoTecnologiaDto.CandidatoId, candidatoTecnologiaDto.TecnologiaId, vagaTecnologia.Peso);
                _candidatoTecnologiaRepository.Armazenar(candidatoTecnologia);
                _uow.Commit();
                return candidatoTecnologiaDto;
            }
            throw new Exception("candidatoTecnologiaDto Nulo");
        }   
    }
}
