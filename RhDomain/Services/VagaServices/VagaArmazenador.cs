using Microsoft.AspNetCore.Mvc;
using RhDomain.Dto;
using RhDomain.Entities.Vagas;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services;
using RhDomain.Interfaces.Services.VagaValidationInterface;
using RhDomain.Interfaces.UnitOfWork;
using RhDomain.Services.VagasValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Services.VagaServices
{
    public class VagaArmazenador : IVagaArmazenador
    {
        private readonly IVagaRepository _vagaRepository;
        private readonly IUnitOfWork _uow;
        private readonly IVagaValidation _vagaValidation;  
        public VagaArmazenador(IVagaRepository vagaRepository, IUnitOfWork uow,
            IVagaValidation vagaValidation)
        {
            _vagaValidation = vagaValidation;
            _uow = uow;
            _vagaRepository = vagaRepository;
        }

        public ActionResult<VagaDto> IncluirVaga(VagaDto vagaDto)
        {
            if (_vagaValidation.ValidaSeVagaDtoEstaPreenchido(vagaDto))
            {
                var vaga = new Vaga(vagaDto.Descricao);
                _vagaRepository.Armazenar(vaga);
                _uow.Commit();
                return vagaDto;
            }
            return null;
        }
    }
}
