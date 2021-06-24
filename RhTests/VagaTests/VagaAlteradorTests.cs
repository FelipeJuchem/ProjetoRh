using Moq;
using RhDomain.Dto;
using RhDomain.Entities.Vagas;
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
    public class VagaAlteradorTests
    {
        private readonly VagaAlterador _vagaAlterador;
        private readonly Mock<IVagaRepository> _vagaRepositoryMock;
        private readonly Mock<IUnitOfWork> _uowMock;
        private readonly Mock<IVagaValidation> _vagaValidationMock;

        public VagaAlteradorTests()
        {
            _vagaValidationMock = new Mock<IVagaValidation>();
            _vagaRepositoryMock = new Mock<IVagaRepository>();
            _uowMock = new Mock<IUnitOfWork>();
            _vagaAlterador = new VagaAlterador(_vagaRepositoryMock.Object, _uowMock.Object, _vagaValidationMock.Object);
        }

        [Fact]
        public void DeveAlterarVaga()
        {
            CriaSetupComVagaValida();
            var vaga = new Vaga("Teste1");
            
            var vagaDto = new VagaComTecnologiaECandidatosDto
            {
                Descricao = "Teste2"
            };

            _vagaRepositoryMock.Setup(x => x.BuscarPorId(vagaDto.Id)).Returns(vaga);
            var resultado = _vagaAlterador.Alterar(vagaDto);

            Assert.Equal(vagaDto, resultado);
        
        }

        [Fact]
        public void DeveRetornarExceptionComVagaInvalida()
        {
            var vagaDto = new VagaComTecnologiaECandidatosDto
            {
                Descricao = ""
            };
            var exception = Assert.Throws<Exception>(() => _vagaAlterador.Alterar(vagaDto));

            Assert.Equal("Descrição deve estar preenchido!", exception.Message);
        }
        

        private void CriaSetupComVagaValida()
        {
            _vagaValidationMock.Setup(x => x.ValidaSeVagaDtoEstaPreenchido(It.IsAny<VagaComTecnologiaECandidatosDto>())).Returns(true);
        }
    }
}
