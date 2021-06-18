using RhDomain.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RhDomain.Interfaces.Services
{
    public interface ICandidatoTecnologiaConsulta
    {
        Task<List<CandidatoTecnologiaDto>> BuscarListaCandidatoTecnologia();
        CandidatoTecnologiaDto BuscarPorIdDuplo(int candidatoId, int TecnologiaId);
    }
}
