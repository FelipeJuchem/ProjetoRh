using RhDomain.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Interfaces.Services.TecnologiaValidation
{
    public interface ITecnologiaValidation
    {
        bool ValidaSeTecnologiaEstaPreenchido(TecnologiaDto tecnologiaDto);
    }
}
