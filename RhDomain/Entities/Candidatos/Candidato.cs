﻿using RhDomain.Entities.CandidatosTecnologias;
using RhDomain.Entities.Tecnologias;
using RhDomain.Entities.Vagas;
using RhDomain.Entities.VagasTecnologias;
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
        public double Cpf { get; private set; }
        public int VagaId { get; private set; }
        public Vaga Vaga { get; private set; }
        public IList<CandidatoTecnologia> CandidatoTecnologia { get; private set; }

        public Candidato()
        {

        }

        public Candidato(string nome, string sobrenome, double idade, double cpf)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
            Cpf = cpf;
        }




    }
}
