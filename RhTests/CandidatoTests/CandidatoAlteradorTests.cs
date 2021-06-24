using Moq;
using RhDomain.Dto;
using RhDomain.Entities.Candidatos;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services.CandidatoValidationInterface;
using RhDomain.Interfaces.UnitOfWork;
using RhDomain.Services.CandidatoServices;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RhTests.CandidatoTests
{
    public class CandidatoAlteradorTests
    {
        private readonly CandidatoAlterador _candidatoAlterador;
        private readonly Mock<IUnitOfWork> _uowMock;
        private readonly Mock<ICandidatoRepository> _candidatoRepositoryMock;
        private readonly Mock<ICandidatoValidation> _candidatoValidationMock;

        public CandidatoAlteradorTests()
        {
            _candidatoValidationMock = new Mock<ICandidatoValidation>();
            _candidatoRepositoryMock = new Mock<ICandidatoRepository>();
            _uowMock = new Mock<IUnitOfWork>();
            _candidatoAlterador = new CandidatoAlterador(_uowMock.Object, _candidatoRepositoryMock.Object, _candidatoValidationMock.Object);
        }

        [Fact]
        public void DeveAlterarCandidato()
        {
            CriaSetupComCandidatoValido();
            var candidato = new Candidato("Dunga", "Tunga", 55, "5555555555", 1);

            var candidatoDto = new CandidatoDto
            {
                Nome = "Manu",
                Sobrenome = "Doidu",
                Idade = 32,
                Cpf = "444444444444",
                VagaId = 2
            };

            _candidatoRepositoryMock.Setup(x => x.BuscarPorId(candidatoDto.Id)).Returns(candidato);
            var resultado = _candidatoAlterador.Alterar(candidatoDto);

            Assert.Equal(candidatoDto.Nome, candidato.Nome);
            Assert.Equal(candidatoDto.Sobrenome, candidato.Sobrenome);
            Assert.Equal(candidatoDto.Idade, candidato.Idade);
            Assert.Equal(candidatoDto.Cpf, candidato.Cpf);
            Assert.Equal(candidatoDto.VagaId, candidato.VagaId);
        }

        private void CriaSetupComCandidatoValido()
        {
            _candidatoValidationMock.Setup(x => x.validar(It.IsAny<CandidatoDto>())).Returns(true);
        }

    }
}
