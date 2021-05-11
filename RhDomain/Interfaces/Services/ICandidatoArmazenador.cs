using Microsoft.AspNetCore.Mvc;
using RhDomain.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RhDomain.Interfaces.Services
{
    public interface ICandidatoArmazenador
    {
        ActionResult<CandidatoDto> IncluirCandidato(CandidatoDto candidatoDto);
    }
}
