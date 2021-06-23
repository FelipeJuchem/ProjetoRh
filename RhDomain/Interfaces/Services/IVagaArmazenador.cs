using Microsoft.AspNetCore.Mvc;
using RhDomain.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Interfaces.Services
{
    public interface IVagaArmazenador
    {
        ActionResult<VagaComTecnologiaECandidatosDto> IncluirVaga(VagaComTecnologiaECandidatosDto vagaDto);
    }
}
