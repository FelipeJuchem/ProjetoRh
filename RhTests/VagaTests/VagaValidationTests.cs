using RhDomain.Dto;
using RhDomain.Services.VagasValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RhTests.VagaTests
{
    public class VagaValidationTests
    {
        private readonly VagaValidation _vagaValidation;
        public VagaValidationTests()
        {
            _vagaValidation = new VagaValidation();
        }

        [Fact]
        public void DeveRetornarFalseComVagaNaoPreenchido()
        {
            var vagaDto = new VagaComTecnologiaECandidatosDto
            {
                Descricao = ""
            };

            var resultado = _vagaValidation.ValidaSeVagaDtoEstaPreenchido(vagaDto);

            Assert.False(resultado);
        }

        [Fact]
        public void DeveRetornarTrueComVagaPreenchido()
        {
            var vagaDto = new VagaComTecnologiaECandidatosDto
            {
                Descricao = "Teste"
            };

            var resultado = _vagaValidation.ValidaSeVagaDtoEstaPreenchido(vagaDto);

            Assert.True(resultado);
        }
    }
}
