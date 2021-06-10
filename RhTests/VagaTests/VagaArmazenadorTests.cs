using Moq;
using RhDomain.Dto;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services.VagaValidationInterface;
using RhDomain.Interfaces.UnitOfWork;
using RhDomain.Services.VagaServices;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RhTests.VagaTests
{
    public class VagaArmazenadorTests
    {
        private readonly VagaArmazenador _vagaArmazenador;
        private readonly Mock<IVagaRepository> _vagaRepositoryMock;
        private readonly Mock<IVagaValidation> _vagaValidationMock;
        private readonly Mock<IUnitOfWork> _uowMock;

        public VagaArmazenadorTests()
        {
            _uowMock = new Mock<IUnitOfWork>();
            _vagaValidationMock = new Mock<IVagaValidation>();
            _vagaRepositoryMock = new Mock<IVagaRepository>();
            _vagaArmazenador = new VagaArmazenador(_vagaRepositoryMock.Object, _uowMock.Object, _vagaValidationMock.Object);
        }

        [Fact]
        public void DeveArmazenarVaga()
        {
            CriaSetupComVagaValida();
            var vagaDto = new VagaComTecnologiaDto
            {
                Descricao = "Teste"
            };

            var resultado = _vagaArmazenador.IncluirVaga(vagaDto);

            Assert.NotNull(resultado);
        }

        [Fact]
        public void NaoDeveArmazenarVaga()
        {
            CriaSetupComVagaInvalida();
            var vagaDto = new VagaComTecnologiaDto
            {
                Descricao = "Teste"
            };

            var resultado = _vagaArmazenador.IncluirVaga(vagaDto);

            Assert.Null(resultado);
        }



        public void CriaSetupComVagaValida()
        {
            _vagaValidationMock.Setup(x => x.ValidaSeVagaDtoEstaPreenchido(It.IsAny<VagaComTecnologiaDto>())).Returns(true);
        }

        public void CriaSetupComVagaInvalida()
        {
            _vagaValidationMock.Setup(x => x.ValidaSeVagaDtoEstaPreenchido(It.IsAny<VagaComTecnologiaDto>())).Returns(false);
        }















    }
}
