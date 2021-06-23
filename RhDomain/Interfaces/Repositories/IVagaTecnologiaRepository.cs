using RhDomain.Entities.VagasTecnologias;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RhDomain.Interfaces.Repositories
{
    public interface IVagaTecnologiaRepository : IRepository<int, VagaTecnologia>
    {
        Task<VagaTecnologia> BuscaVagaTecnologiaPorIdDuplo(int vagaId, int tecnologiaId);
        VagaTecnologia BuscaVagaTecnologiaPorTecnologiaId(int tecnologiaId);
        VagaTecnologia BuscaVagaTecnologiaPorVagaId(int vagaId);
    }
}
