using RhDomain.Entities.Candidatos;
using RhDomain.Entities.Tecnologias;
using RhDomain.Entities.VagasTecnologias;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Entities.Vagas
{
    public class Vaga
    {
        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public IList<Candidato> Candidatos { get; set; }
        public IList<VagaTecnologia> VagasTecnologias { get; private set; }

        protected Vaga()
        {

        }

        public Vaga(string descricao)
        {
            Descricao = descricao;
        }

        public void Atualizar(string descricao)
        {
            Descricao = descricao;
        }

    }
}
