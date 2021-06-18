using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Interfaces.Services
{
    public interface IPermitirExclusaoDeVagaTecnologia
    {
        bool ValidaExclusaoDeVagaTecnologia(int vagaId, int tecnologiaId);
    }
}
