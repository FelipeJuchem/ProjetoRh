using Microsoft.AspNetCore.Mvc;
using RhDomain.Dto;
using RhDomain.Entities.Candidatos;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services;
using RhDomain.Interfaces.Services.CandidatoValidationInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Services.CandidatoServices
{
    public class CandidatoArmazenador : ICandidatoArmazenador
    {
        private readonly ICandidatoRepository _candidatoRepository;
        private readonly ICandidatoValidation _candidatoValidation;
        public CandidatoArmazenador(ICandidatoRepository candidatoRepository, ICandidatoValidation candidatoValidation)
        {
            _candidatoRepository = candidatoRepository;
            _candidatoValidation = candidatoValidation;
        }

        public ActionResult<CandidatoDto> IncluirCandidato(CandidatoDto candidatoDto)
        {
            if (_candidatoValidation.validar(candidatoDto))
            {
                var candidato = new Candidato(candidatoDto.Nome, candidatoDto.Sobrenome, candidatoDto.Idade, candidatoDto.Cpf);
                _candidatoRepository.Armazenar(candidato);
                return candidatoDto;
            }
            return null;
        }
    }
}
