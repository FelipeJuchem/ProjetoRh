using Microsoft.AspNetCore.Mvc;
using RhDomain.Dto;
using RhDomain.Entities.Candidatos;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services;
using RhDomain.Interfaces.Services.CandidatoValidationInterface;
using RhDomain.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Services.CandidatoServices
{
    public class CandidatoArmazenador : ICandidatoArmazenador
    {
        private readonly IUnitOfWork _uow;
        private readonly ICandidatoRepository _candidatoRepository;
        private readonly ICandidatoValidation _candidatoValidation;
        public CandidatoArmazenador(ICandidatoRepository candidatoRepository, ICandidatoValidation candidatoValidation,
            IUnitOfWork uow)
        {
            _uow = uow;
            _candidatoRepository = candidatoRepository;
            _candidatoValidation = candidatoValidation;
        }

        public ActionResult<CandidatoDto> IncluirCandidato(CandidatoDto candidatoDto)
        {
            if (_candidatoValidation.validar(candidatoDto))
            {
                var candidato = new Candidato(candidatoDto.Nome, candidatoDto.Sobrenome, candidatoDto.Idade, candidatoDto.Cpf, candidatoDto.VagaId);
                _candidatoRepository.Armazenar(candidato);
                _uow.Commit();
                return candidatoDto;
            }
            return null;
        }
    }
}
