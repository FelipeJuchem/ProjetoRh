using RhDomain.Dto;
using RhDomain.Interfaces.Services.CandidatoValidationInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Services.CandidatoValidations
{
    public class CandidatoValidation : ICandidatoValidation
    {
        public bool validar(CandidatoDto candidatoDto)
        {
            return VerificarSeNomeEstaPreenchido(candidatoDto) &&
                VerificarSeSobrenomeEstaPreenchido(candidatoDto) &&
                VerificarSeIdadeEstaPreenchido(candidatoDto) &&
                VerificarSeIdadeEstaPreenchido(candidatoDto);
        }

        public bool VerificarSeNomeEstaPreenchido(CandidatoDto candidatoDto)
        {
            if (string.IsNullOrWhiteSpace(candidatoDto.Nome))
            {
                return false;
            }
            return true;
        }

        public bool VerificarSeSobrenomeEstaPreenchido(CandidatoDto candidatoDto)
        {
            if (string.IsNullOrEmpty(candidatoDto.Sobrenome))
            {
                return false;
            }
            return true;
        }

        public bool VerificarSeIdadeEstaPreenchido(CandidatoDto candidatoDto)
        {
            if(candidatoDto.Idade == 0)
            {
                return false;
            }
            return true;
        }

        public bool VerificarSeCpfEstaPreenchido(CandidatoDto candidatoDto)
        {
            if(string.IsNullOrWhiteSpace(candidatoDto.Cpf))
            {
                return false;
            }
            return true;
        }
    }
}
