using RhDomain.Dto;
using RhDomain.Entities.Candidatos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RhDomain.Interfaces.Repositories
{
    public interface ICandidatoRepository : IRepository<int, Candidato>
    {
        Candidato BuscaCandidatoTecnologiaComTecnologias(int id);
        Candidato BuscarParaArmazenarCandidatoTecnologia(CandidatoComTecnologiaParaArmazenarDto candidatoComTecnologiaParaArmazenarDto);
        Task<List<Candidato>> BuscarListaCandidatosComVagaDescricao(); 
    }
}
