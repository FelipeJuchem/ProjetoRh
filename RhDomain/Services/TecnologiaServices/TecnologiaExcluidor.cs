using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services;
using RhDomain.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Services.TecnologiaServices
{
    public class TecnologiaExcluidor : ITecnologiaExcluidor
    {
        private readonly ITecnologiaRepository _tecnologiaRepository;
        private readonly IUnitOfWork _uow;

        public TecnologiaExcluidor(ITecnologiaRepository tecnologiaRepository, IUnitOfWork uow)
        {
            _tecnologiaRepository = tecnologiaRepository;
            _uow = uow;
        }
        public void ExcluirTecnologia(int id)
        {
            var tecnologia = _tecnologiaRepository.BuscarPorId(id);
            _tecnologiaRepository.Excluir(tecnologia);
            _uow.Commit();
        }
    }
}
