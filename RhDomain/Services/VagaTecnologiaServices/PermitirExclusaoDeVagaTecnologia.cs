using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Services.VagaTecnologiaServices
{
    public class PermitirExclusaoDeVagaTecnologia : IPermitirExclusaoDeVagaTecnologia
    {
        private readonly IVagaRepository _vagaRepository;

        public PermitirExclusaoDeVagaTecnologia(IVagaRepository vagaRepository)
        {
            _vagaRepository = vagaRepository;
        }

        public bool ValidaExclusaoDeVagaTecnologia(int vagaId,int tecnologiaId)
        {
            var vaga = _vagaRepository.BuscaVagaComInclude(vagaId);

            if (vaga == null)
                throw new Exception("Vaga não existe");

            foreach(var candidato in vaga.Candidatos)
            {
                 foreach(var tecnologia in candidato.CandidatosTecnologias)
                 {
                    if(tecnologia.TecnologiaId == tecnologiaId)
                    {
                        return false;
                    }
                 }
            }
            return true;
        }
    }
}
