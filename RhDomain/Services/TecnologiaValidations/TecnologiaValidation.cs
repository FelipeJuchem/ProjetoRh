using RhDomain.Dto;
using RhDomain.Interfaces.Services.TecnologiaValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Services.TecnologiaValidations
{
    public class TecnologiaValidation : ITecnologiaValidation
    {
        public bool ValidaSeTecnologiaEstaPreenchido(TecnologiaDto tecnologiaDto)
        {
            if (string.IsNullOrEmpty(tecnologiaDto.Descricao))
            {
                return false;
            }
            return true;
        }
    }
}
