using RhDomain.Dto;
using RhDomain.Interfaces.Services.VagaValidationInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Services.VagasValidation
{
    public class VagaValidation : IVagaValidation
    {
        public bool ValidaSeVagaDtoEstaPreenchido(VagaComTecnologiaECandidatosDto vagaDto)
        {
            if (string.IsNullOrEmpty(vagaDto.Descricao))
            {
                return false;
            }
            return true;
        }
    }
}
