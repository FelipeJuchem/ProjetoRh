using RhDomain.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RhDomain.Interfaces.Services
{
    public interface ICandidatoTecnologiaArmazenador
    {
        Task<CandidatoTecnologiaDto> IncluirCandidatoTecnologia(CandidatoTecnologiaDto candidatoTecnologiaDto);
    }
}
