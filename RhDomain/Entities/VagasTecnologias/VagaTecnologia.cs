using RhDomain.Entities.Tecnologias;
using RhDomain.Entities.Vagas;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Entities.VagasTecnologias
{
    public class VagaTecnologia
    {
        public int VagaId { get; private set; }
        public int TecnologiaId { get; private set; }
        public Vaga Vaga { get; private set; }
        public Tecnologia Tecnologia { get; private set; }

        public VagaTecnologia()
        {

        }

        public VagaTecnologia(int vagaId, int tecnologiaId)
        {
            VagaId = vagaId;
            TecnologiaId = tecnologiaId;
        }

    }
}
