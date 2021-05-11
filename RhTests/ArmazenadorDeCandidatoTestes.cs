using Moq;
using RhDomain.Dto;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services;
using RhDomain.Interfaces.Services.CandidatoValidationInterface;
using RhDomain.Services.CandidatoServices;
using System;
using Xunit;

namespace RhTests
{
    public class ArmazenadorDeCandidatoTestes
    {
        private readonly CandidatoArmazenador _candidatoArmazenador;
        private readonly Mock<ICandidatoRepository> _candidatoRepositoryMock;
        private readonly Mock<ICandidatoValidation> _candidatoValidationMock;

        public ArmazenadorDeCandidatoTestes()
        {
            _candidatoValidationMock = new Mock<ICandidatoValidation>();
            _candidatoRepositoryMock = new Mock<ICandidatoRepository>();
            _candidatoArmazenador = new CandidatoArmazenador(_candidatoRepositoryMock.Object, _candidatoValidationMock.Object);
        }

        [Fact]
        public void DeveArmazenarCandidato()
        {
            CriaSetupComCandidatoValido();
            var candidatoDto = new CandidatoDto
            {
                Nome = "Tungo",
                Sobrenome = "Manotungo",
                Idade = 17,
                Cpf = "55,55,11,44"
            };

            var resultado = _candidatoArmazenador.IncluirCandidato(candidatoDto);

            Assert.NotNull(resultado);
        }

        public void CriaSetupComCandidatoValido()
        {
            _candidatoValidationMock.Setup(x => x.validar(It.IsAny<CandidatoDto>())).Returns(true);
        }
    }
}
