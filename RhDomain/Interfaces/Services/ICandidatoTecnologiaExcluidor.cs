using RhDomain.Entities.CandidatosTecnologias;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Interfaces.Services
{
    public interface ICandidatoTecnologiaExcluidor
    {
        void Deletar(int candidatoId, int tecnologiaId);
    }
}
