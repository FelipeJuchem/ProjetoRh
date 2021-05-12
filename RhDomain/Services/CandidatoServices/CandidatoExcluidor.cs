using AutoMapper;
using RhDomain.Dto;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services;
using RhDomain.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RhDomain.Services.CandidatoServices
{
    public class CandidatoExcluidor : ICandidatoExcluidor
    {
        private readonly ICandidatoRepository _candidatoRepository;
        private readonly IUnitOfWork _uow;
        
        
        public CandidatoExcluidor(ICandidatoRepository candidatoRepository, IUnitOfWork uow)
        {
            _uow = uow;
            _candidatoRepository = candidatoRepository;
        }
        public void ExcluirCandidatoPeloId(int id)
        {
            var candidato = _candidatoRepository.BuscarPorId(id);
            if (candidato == null)
            {
                return;
            }
            _candidatoRepository.Excluir(candidato);
            _uow.Commit();
        }
    }
}
