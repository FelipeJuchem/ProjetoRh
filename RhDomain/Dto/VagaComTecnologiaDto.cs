using RhDomain.Entities.VagasTecnologias;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Dto
{
    public class VagaComTecnologiaDto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public List<TecnologiaDto> Tecnologias { get; set; }

    }
}
