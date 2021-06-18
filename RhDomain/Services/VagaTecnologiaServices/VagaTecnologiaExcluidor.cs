using RhDomain.Dto;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services;
using RhDomain.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RhDomain.Services.VagaTecnologiaServices
{
    public class VagaTecnologiaExcluidor : IVagaTecnologiaExcluidor
    {
        private readonly IPermitirExclusaoDeVagaTecnologia _permitirExclusaoDeVagaTecnologia;
        private readonly IVagaTecnologiaRepository _vagaTecnologiaRepository;
        private readonly IUnitOfWork _uow;

        public VagaTecnologiaExcluidor(IVagaTecnologiaRepository vagaTecnologiaRepository, IUnitOfWork uow, IPermitirExclusaoDeVagaTecnologia permitirExclusaoDeVagaTecnologia)
        {
            _vagaTecnologiaRepository = vagaTecnologiaRepository;
            _uow = uow;
            _permitirExclusaoDeVagaTecnologia = permitirExclusaoDeVagaTecnologia;
        }

        public async Task<bool> Deletar(int vagaId, int tecnologiaId)
        {
            if(_permitirExclusaoDeVagaTecnologia.ValidaExclusaoDeVagaTecnologia(vagaId, tecnologiaId))
            {
                var vagaTecnologia = _vagaTecnologiaRepository.BuscaVagaTecnologiaPorIdDuplo(vagaId, tecnologiaId);
                _vagaTecnologiaRepository.Excluir(vagaTecnologia);
                _uow.Commit();
                return true;
            }
            return false;
        }
    }
}
