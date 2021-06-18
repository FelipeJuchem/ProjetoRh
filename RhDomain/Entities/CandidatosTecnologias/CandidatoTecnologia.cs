using RhDomain.Entities.Candidatos;
using RhDomain.Entities.Tecnologias;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Entities.CandidatosTecnologias
{
    public class CandidatoTecnologia
    {
        public int CandidatoId { get; set; }
        public Candidato Candidato { get; set; }
        public int TecnologiaId { get; set; }
        public Tecnologia Tecnologia { get; set; }
        public int Peso { get; set; }



        public CandidatoTecnologia(int candidatoId, int tecnologiaId, int peso)
        {
            CandidatoId = candidatoId;
            TecnologiaId = tecnologiaId;
            Peso = peso;
        }
    }
}
