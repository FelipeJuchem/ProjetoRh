using RhDomain.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Interfaces.Services.VagaValidationInterface
{
    public interface IVagaValidation
    {
        bool ValidaSeVagaDtoEstaPreenchido(VagaComTecnologiaECandidatosDto vagaDto);
    }
}
