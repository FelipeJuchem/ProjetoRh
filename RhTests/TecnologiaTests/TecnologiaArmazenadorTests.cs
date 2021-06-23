using Moq;
using RhDomain.Dto;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services.TecnologiaValidation;
using RhDomain.Interfaces.UnitOfWork;
using RhDomain.Services.TecnologiaServices;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RhTests.TecnologiaTests
{
    public class TecnologiaArmazenadorTests
    {
        private readonly TecnologiaArmazenador _tecnologiaArmazenador;
        private readonly Mock<ITecnologiaRepository> _tecnologiaRepositoryMock;
        private readonly Mock<ITecnologiaValidation> _tecnologiaValidationMock;
        private readonly Mock<IUnitOfWork> _uowMock;

        public TecnologiaArmazenadorTests()
        {
            _uowMock = new Mock<IUnitOfWork>();
            _tecnologiaValidationMock = new Mock<ITecnologiaValidation>();
            _tecnologiaRepositoryMock = new Mock<ITecnologiaRepository>();
            _tecnologiaArmazenador = new TecnologiaArmazenador(_tecnologiaRepositoryMock.Object, _tecnologiaValidationMock.Object, _uowMock.Object);
        }

        [Fact]
        public void DeveArmazenarTecnologia()
        {
            CriaSetupComTecnologiaValida();
            var tecnologiaDto = new TecnologiaDto
            {
                Descricao = "Teste"
            };
            var resultado = _tecnologiaArmazenador.IncluirTecnologia(tecnologiaDto);

            Assert.NotNull(resultado);
        }

        [Fact]
        public void NaoDeveArmazenarTecnologia()
        {
            CriaSetupComTecnologiaInvalida();
            var tecnologiaDto = new TecnologiaDto
            {
                Descricao = "Teste"
            };
            var resultado = _tecnologiaArmazenador.IncluirTecnologia(tecnologiaDto);

            Assert.Null(resultado);
        }


        public void CriaSetupComTecnologiaValida()
        {
            _tecnologiaValidationMock.Setup(x => x.ValidaSeTecnologiaEstaPreenchido(It.IsAny<TecnologiaDto>())).Returns(true);
        }

        public void CriaSetupComTecnologiaInvalida()
        {
            _tecnologiaValidationMock.Setup(x => x.ValidaSeTecnologiaEstaPreenchido(It.IsAny<TecnologiaDto>())).Returns(false);
        }

    }
}
