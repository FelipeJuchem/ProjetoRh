using RhDomain.Entities.Candidatos;
using RhDomain.Entities.Vagas;
using RhDomain.Entities.VagasTecnologias;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Entities.Tecnologias
{
    public class Tecnologia
    {
        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public int Peso { get; private set; }
        public IList<VagaTecnologia> VagasTecnologias { get; private set; }

        public Tecnologia()
        {

        }

        public Tecnologia(string descricao, int peso)
        {
            Descricao = descricao;
            Peso = peso;
        }
    }
}
