using RhDomain.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Interfaces.Services.CandidatoValidationInterface
{
    public interface ICandidatoValidation
    {
        bool validar(CandidatoDto candidatoDto);
    }
}
