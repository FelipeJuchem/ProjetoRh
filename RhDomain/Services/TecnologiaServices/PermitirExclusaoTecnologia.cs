using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Services.TecnologiaServices
{
    public class PermitirExclusaoTecnologia : IPermitirExclusaoTecnologia
    {
        private readonly IVagaTecnologiaRepository _vagaTecnologiaRepository;
        private readonly ICandidatoTecnologiaRepository _candidatoTecnologiaRepository;

        public PermitirExclusaoTecnologia(IVagaTecnologiaRepository vagaTecnologiaRepository, ICandidatoTecnologiaRepository candidatoTecnologiaRepository)
        {
            _vagaTecnologiaRepository = vagaTecnologiaRepository;
            _candidatoTecnologiaRepository = candidatoTecnologiaRepository;
        }

        public bool ValidaExclusaoTecnologia(int tecnologiaId)
        {
            var vagaTecnologia = _vagaTecnologiaRepository.BuscaVagaTecnologiaPorTecnologiaId(tecnologiaId);
            var candidatoTecnologia = _candidatoTecnologiaRepository.BuscarCandidatoTecnologiaPorTecnologiaId(tecnologiaId);
            if (vagaTecnologia != null)
            {
                throw new Exception("Tecnologia vinculada a uma vaga, não é possivel a exclusão!");
            }
            if(candidatoTecnologia != null)
            {
                throw new Exception("Algum candidato tem está tecnologia vinculada, não é possivel a exlusão!");
            }
            return true;
            
        }
    }
}
