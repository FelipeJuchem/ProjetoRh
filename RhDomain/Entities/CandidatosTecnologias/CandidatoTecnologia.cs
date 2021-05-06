using RhDomain.Entities.Candidatos;
using RhDomain.Entities.Tecnologias;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Entities.CandidatosTecnologias
{
    public class CandidatoTecnologia
    {
        public int CandidatoId { get; private set; }
        public int TecnologiaId { get; private set; }
        public Candidato Candidato { get; private set; }
        public Tecnologia Tecnologia { get; private set; }

        public CandidatoTecnologia()
        {

        }

        public CandidatoTecnologia(int candidatoId, int tecnologiaId)
        {
            CandidatoId = candidatoId;
            TecnologiaId = tecnologiaId;
        }
    }
}
