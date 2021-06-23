using RhDomain.Entities.CandidatosTecnologias;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Interfaces.Repositories
{
    public interface ICandidatoTecnologiaRepository : IRepository<int, CandidatoTecnologia>
    {
        CandidatoTecnologia BuscarCandidatoTecnologiaporDuploId(int candidatoId, int tecnologiaId);

        CandidatoTecnologia BuscarCandidatoTecnologiaPorTecnologiaId(int tecnologiaId);
    }
}
