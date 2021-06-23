using RhDomain.Dto;
using RhDomain.Services.TecnologiaValidations;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RhTests.TecnologiaTests
{
    public class TecnologiaValidationTests
    {
        private readonly TecnologiaValidation _tecnologiaValidation;
        public TecnologiaValidationTests()
        {
            _tecnologiaValidation = new TecnologiaValidation();
        }

        [Fact]
        public void DeveRetornarFalsoComDescricaoNaoPreenchida()
        {
            var tecnologiaDto = new TecnologiaDto
            {
                Descricao = ""
            };
            
            var resultado = _tecnologiaValidation.ValidaSeTecnologiaEstaPreenchido(tecnologiaDto);

            Assert.False(resultado);
        }

        [Fact]
        public void DeveRetornarTrueComDescricaoNaoPreenchida()
        {
            var tecnologiaDto = new TecnologiaDto
            {
                Descricao = "teste"
            };

            var resultado = _tecnologiaValidation.ValidaSeTecnologiaEstaPreenchido(tecnologiaDto);

            Assert.True(resultado);
        }


    }
}
