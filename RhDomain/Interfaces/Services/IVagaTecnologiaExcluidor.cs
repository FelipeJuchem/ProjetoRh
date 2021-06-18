using RhDomain.Entities.VagasTecnologias;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RhDomain.Interfaces.Services
{
    public interface IVagaTecnologiaExcluidor
    {
        Task<bool> Deletar(int vagaId, int tecnologiaId);
    }
}
