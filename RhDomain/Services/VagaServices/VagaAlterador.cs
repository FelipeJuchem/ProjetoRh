using RhDomain.Dto;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services;
using RhDomain.Interfaces.Services.VagaValidationInterface;
using RhDomain.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Services.VagaServices
{
    public class VagaAlterador : IVagaAlterador
    {
        private readonly IVagaRepository _vagaRepository;
        private readonly IUnitOfWork _uow;
        private readonly IVagaValidation _vagaValidation;

        public VagaAlterador(IVagaRepository vagaRepository, IUnitOfWork uow, IVagaValidation vagaValidation)
        {
            _uow = uow;
            _vagaRepository = vagaRepository;
            _vagaValidation = vagaValidation;
        }

        public VagaComTecnologiaDto Alterar(VagaComTecnologiaDto vagaDto)
        {
            if (_vagaValidation.ValidaSeVagaDtoEstaPreenchido(vagaDto))
            {
                var vaga = _vagaRepository.BuscarPorId(vagaDto.Id);
                vaga.Atualizar(vagaDto.Descricao);
                _vagaRepository.Alterador(vaga);
                _uow.Commit();
                return vagaDto;
            }
            return null;
        }
    }
}
