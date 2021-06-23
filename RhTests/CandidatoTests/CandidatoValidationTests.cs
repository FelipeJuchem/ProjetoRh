using RhDomain.Dto;
using RhDomain.Services.CandidatoValidations;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RhTests.CandidatoTests
{
    public class CandidatoValidationTests
    {

        private readonly CandidatoValidation _candidatoValidation;

        public CandidatoValidationTests()
        {
            _candidatoValidation = new CandidatoValidation();
        }

        [Fact]
        public void DeveRetornarTrueSeCandidatoEValido()
        {
            var candidatoDto = new CandidatoDto
            {
                Nome = "Dunga",
                Sobrenome = "Tunga",
                Idade = 25,
                Cpf = "5555555555",
                VagaId = 1
            };
            
            var resultado = _candidatoValidation.validar(candidatoDto);

            Assert.True(resultado);
        }

        [Fact]
        public void DeveRetornarFalsoComNomeNaoPreenchido()
        {
            var candidatoDto = new CandidatoDto
            {
                Nome = "",
                Sobrenome = "Tunga",
                Idade = 25,
                Cpf = "5555555555",
                VagaId = 1
            };

            var resultado = _candidatoValidation.VerificarSeNomeEstaPreenchido(candidatoDto);

            Assert.False(resultado);
        }

        [Fact]
        public void DeveRetornarFalsoComSobrenomeNaoPreenchido()
        {
            var candidatoDto = new CandidatoDto
            {
                Nome = "Dunga",
                Sobrenome = "",
                Idade = 25,
                Cpf = "5555555555",
                VagaId = 1
            };

            var resultado = _candidatoValidation.VerificarSeSobrenomeEstaPreenchido(candidatoDto);

            Assert.False(resultado);
        }

        [Fact]
        public void DeveRetornarFalsoComCpfNaoPreenchido()
        {
            var candidatoDto = new CandidatoDto
            {
                Nome = "Dunga",
                Sobrenome = "Tunga",
                Idade = 25,
                Cpf = "",
                VagaId = 1
            };

            var resultado = _candidatoValidation.VerificarSeCpfEstaPreenchido(candidatoDto);

            Assert.False(resultado);
        }

        [Fact]
        public void DeveRetornarFalsoComIdadeIgualAZero()
        {
            var candidatoDto = new CandidatoDto
            {
                Nome = "Dunga",
                Sobrenome = "Tunga",
                Idade = 0,
                Cpf = "5555555555",
                VagaId = 1
            };

            var resultado = _candidatoValidation.VerificarSeIdadeEstaPreenchido(candidatoDto);

            Assert.False(resultado);
        }
    }
}
