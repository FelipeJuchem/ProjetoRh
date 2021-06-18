using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Dto
{
    public class CandidatoComTecnologiaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public double Idade { get; set; }
        public string Cpf { get; set; }
        public int VagaId { get; set; }
        public List<TecnologiaDto> Tecnologias { get; set; }

    }
}
