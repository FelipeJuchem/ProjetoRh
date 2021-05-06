using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Dto
{
    public class CandidatoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public double Idade { get; set; }
        public double Cpf { get; set; }
        public int VagaId { get; set; }
    }
}
