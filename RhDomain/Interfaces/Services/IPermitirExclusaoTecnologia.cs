using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Interfaces.Services
{
    public interface IPermitirExclusaoTecnologia
    {
        bool ValidaExclusaoTecnologia(int tecnologiaId);
    }
}
