using RhDomain.Entities.Tecnologias;
using RhDomain.Entities.Vagas;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Entities.Candidatos
{
    public class Candidato
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public double Idade { get; private set; }
        public string Cpf { get; private set; }
        public int VagaId { get; private set; }
        public Vaga Vaga { get; private set; }
        public IList<Tecnologia> Tecnologias { get; private set; }

        public Candidato()
        {

        }

        public Candidato(string nome, string sobrenome, double idade, string cpf, int vagaId)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
            Cpf = cpf;
            VagaId = vagaId;
        }

        public void Atualizar(string nome, string sobrenome, double idade, string cpf, int vagaId)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
            Cpf = cpf;
            VagaId = vagaId;
        }




    }
}
