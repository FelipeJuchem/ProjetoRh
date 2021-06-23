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
        private readonly IPermitirExclusaoTecnologia _permitirExclusaoTecnologia;

        public TecnologiaExcluidor(ITecnologiaRepository tecnologiaRepository, IUnitOfWork uow, IPermitirExclusaoTecnologia permitirExclusaoTecnologia)
        {
            _tecnologiaRepository = tecnologiaRepository;
            _uow = uow;
            _permitirExclusaoTecnologia = permitirExclusaoTecnologia;
        }
        public bool ExcluirTecnologia(int id)
        {
            if (_permitirExclusaoTecnologia.ValidaExclusaoTecnologia(id))
            {
                var tecnologia = _tecnologiaRepository.BuscarPorId(id);
                _tecnologiaRepository.Excluir(tecnologia);
                _uow.Commit();
                return true;
            }
            return false;
        }
    }
}
