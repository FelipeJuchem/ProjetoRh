using RhDomain.Entities.Tecnologias;
using RhDomain.Entities.Vagas;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Entities.VagasTecnologias
{
    public class VagaTecnologia
    {
        public int VagaId { get; set; }
        public int TecnologiaId { get; set; }
        public Vaga Vagas { get; set; }
        public Tecnologia Tecnologias { get; set; }

    }
}
