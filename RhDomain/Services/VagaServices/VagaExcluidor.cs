using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services;
using RhDomain.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Services.VagaServices
{
    public class VagaExcluidor : IVagaExcluidor
    {
        private readonly IVagaRepository _vagaRepository;
        private readonly IUnitOfWork _uow;

        public VagaExcluidor(IVagaRepository vagaRepository, IUnitOfWork uow)
        {
            _vagaRepository = vagaRepository;
            _uow = uow;
        }

        public void ExcluirVagaPeloId(int id)
        {
            var vaga = _vagaRepository.BuscarPorId(id);
            if(vaga == null)
            {
                throw new Exception("nao encontrado");
            }
            _vagaRepository.Excluir(vaga);
            _uow.Commit();
        }
    }
}
