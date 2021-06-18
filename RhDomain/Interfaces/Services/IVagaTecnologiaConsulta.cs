using RhDomain.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RhDomain.Interfaces.Services
{
    public interface IVagaTecnologiaConsulta
    {
        Task<List<VagaTecnologiaDto>> BuscarListaVagaTecnologia();
        VagaTecnologiaDto BuscaVagaTecnologiaPorId(int vagaId, int tecnologiaId);
    }
}
