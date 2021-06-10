using RhDomain.Entities.VagasTecnologias;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Dto
{
    public class TecnologiaDto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Peso { get; set; }

        //static public TecnologiaDto DeVagaTecnologia(VagaTecnologia vagaTecnologia)
        //{
        //    var dto = new TecnologiaDto();
        //    dto.Id = vagaTecnologia.Tecnologia.Id;
        //    dto.Descricao = vagaTecnologia.Tecnologia.Descricao;
        //    dto.Peso = vagaTecnologia.Peso;
        //    return dto;
        //}

    }
}
