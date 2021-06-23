using Moq;
using RhDomain.Dto;
using RhDomain.Entities.Candidatos;
using RhDomain.Entities.CandidatosTecnologias;
using RhDomain.Entities.VagasTecnologias;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.UnitOfWork;
using RhDomain.Services.CandidatoTecnologiaServices;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RhTests.CandidatoTecnologiaTests
{
    public class CandidatoTecnologiaArmazenadorTests
    {

        private readonly CandidatoTecnologiaArmazenador _candidatoTecnologiaArmazenador;
        private readonly Mock<IUnitOfWork> _uowMock;
        private readonly Mock<ICandidatoTecnologiaRepository> _candidatoTecnologiaRepositoryMock;
        private readonly Mock<ICandidatoRepository> _candidatoRepositoryMock;
        private readonly Mock<IVagaTecnologiaRepository> _vagaTecnologiaRepositoryMock;

        public CandidatoTecnologiaArmazenadorTests()
        {
            _candidatoRepositoryMock = new Mock<ICandidatoRepository>();
            _uowMock = new Mock<IUnitOfWork>();
            _vagaTecnologiaRepositoryMock = new Mock<IVagaTecnologiaRepository>();
            _candidatoTecnologiaRepositoryMock = new Mock<ICandidatoTecnologiaRepository>();
            _candidatoRepositoryMock = new Mock<ICandidatoRepository>();
            _candidatoTecnologiaArmazenador = new CandidatoTecnologiaArmazenador(_candidatoTecnologiaRepositoryMock.Object,
                _uowMock.Object, _vagaTecnologiaRepositoryMock.Object, _candidatoRepositoryMock.Object);
        }

        [Fact]
        public void DeveArmazenarCandidatoTecnologia()
        {
            var candidatoTecnologiaDto = new CandidatoTecnologiaDto
            {
                CandidatoId = 1,
                TecnologiaId = 1,
                Peso = 20
            };

            var candidato = new Candidato("Test", "test", 55, "22222222", 1);
            var vagaTecnologia = new VagaTecnologia(1, 1, 20);
            var candidatoTecnologia = new CandidatoTecnologia(1, 1, 20);
            _candidatoRepositoryMock.Setup(x => x.BuscarPorId(1)).Returns(candidato);
            _vagaTecnologiaRepositoryMock.Setup(x => x.BuscaVagaTecnologiaPorIdDuplo(1, 1)).Returns(vagaTecnologia);
            var resultado = _candidatoTecnologiaArmazenador.IncluirCandidatoTecnologia(candidatoTecnologiaDto);


            Assert.NotNull(resultado);
        }


    }
}
