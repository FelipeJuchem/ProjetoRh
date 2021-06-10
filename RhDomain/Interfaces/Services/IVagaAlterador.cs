using RhDomain.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Interfaces.Services
{
    public interface IVagaAlterador
    {
        VagaComTecnologiaDto Alterar(VagaComTecnologiaDto vagaDto);
    }
}
