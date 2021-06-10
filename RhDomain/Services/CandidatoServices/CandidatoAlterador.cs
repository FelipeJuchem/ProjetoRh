using RhDomain.Dto;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services;
using RhDomain.Interfaces.Services.CandidatoValidationInterface;
using RhDomain.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Services.CandidatoServices
{
    public class CandidatoAlterador : ICandidatoAlterador
    {
        private readonly IUnitOfWork _uow;
        private readonly ICandidatoRepository _candidatoRepository;
        private readonly ICandidatoValidation _candidatoValidation;

        public CandidatoAlterador(IUnitOfWork uow, ICandidatoRepository candidatoRepository,
            ICandidatoValidation candidatoValidation)
        {
            _uow = uow;
            _candidatoRepository = candidatoRepository;
            _candidatoValidation = candidatoValidation;
        }

        public CandidatoDto Alterar(CandidatoDto candidatoDto)
        {
            if (_candidatoValidation.validar(candidatoDto))
            {
                var candidato = _candidatoRepository.BuscarPorId(candidatoDto.Id);
                candidato.Atualizar(candidatoDto.Nome, candidatoDto.Sobrenome,
                    candidatoDto.Idade, candidatoDto.Cpf, candidatoDto.VagaId);
                _candidatoRepository.Alterador(candidato);
                _uow.Commit();
                return candidatoDto;
            }
            return null;
        }
    }
}
