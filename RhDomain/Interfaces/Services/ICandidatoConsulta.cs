using RhDomain.Dto;
using RhDomain.Entities.Candidatos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Interfaces.Services
{
    public interface ICandidatoConsulta
    {
        List<CandidatoDto> ObterListaCandidatos();
        CandidatoDto ObterPorId(int id);
    }
}
