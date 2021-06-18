using RhDomain.Dto;
using RhDomain.Entities.Candidatos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RhDomain.Interfaces.Services
{
    public interface ICandidatoConsulta
    {
        Task<List<CandidatoDto>> ObterListaCandidatos();
        CandidatoDto ObterPorId(int id);

        CandidatoComTecnologiaDto ObterCandidatoComTecnologia(int id);
        CandidatoComTecnologiaParaArmazenarDto BuscarParaArmazenarCandidatoTecnologia(
            CandidatoComTecnologiaParaArmazenarDto candidatoComTecnologiaParaArmazenarDto);
    }
}
