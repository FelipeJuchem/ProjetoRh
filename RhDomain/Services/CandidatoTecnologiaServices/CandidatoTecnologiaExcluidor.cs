using AutoMapper;
using RhDomain.Entities.CandidatosTecnologias;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services;
using RhDomain.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Services.CandidatoTecnologiaServices
{
    public class CandidatoTecnologiaExcluidor : ICandidatoTecnologiaExcluidor
    {
        private readonly ICandidatoTecnologiaRepository _candidatoTecnologiaRepository;
        private readonly IUnitOfWork _uow;

        public CandidatoTecnologiaExcluidor(ICandidatoTecnologiaRepository candidatoTecnologiaRepository,IUnitOfWork uow)
        {
            _candidatoTecnologiaRepository = candidatoTecnologiaRepository;
            _uow = uow;
        }

        public void Deletar(int candidatoId, int tecnologiaId)
        {
            var candidatoTecnologia = _candidatoTecnologiaRepository.BuscarCandidatoTecnologiaporDuploId(candidatoId, tecnologiaId);
            _candidatoTecnologiaRepository.Excluir(candidatoTecnologia);
            _uow.Commit();
        }
    }
}
