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
        public int Peso { get; set; }
        public virtual Vaga Vaga { get; set; }
        public virtual Tecnologia Tecnologia { get; set; }


        public VagaTecnologia(int vagaId, int tecnologiaId, int peso)
        {
            VagaId = vagaId;
            TecnologiaId = tecnologiaId;
            Peso = peso;
        }



    }

    
}
