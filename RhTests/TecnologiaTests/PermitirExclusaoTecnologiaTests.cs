using Moq;
using RhDomain.Entities.CandidatosTecnologias;
using RhDomain.Entities.VagasTecnologias;
using RhDomain.Interfaces.Repositories;
using RhDomain.Services.TecnologiaServices;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RhTests.TecnologiaTests
{
    public class PermitirExclusaoTecnologiaTests
    {
        private readonly PermitirExclusaoTecnologia _permitirExclusaoTecnologia;
        private readonly Mock<IVagaTecnologiaRepository> _vagaTecnologiaRepositoryMock;
        private readonly Mock<ICandidatoTecnologiaRepository> _candidatoTecnologiaRepositoryMock;

        public PermitirExclusaoTecnologiaTests()
        {
            _vagaTecnologiaRepositoryMock = new Mock<IVagaTecnologiaRepository>();
            _candidatoTecnologiaRepositoryMock = new Mock<ICandidatoTecnologiaRepository>();
            _permitirExclusaoTecnologia = new PermitirExclusaoTecnologia(_vagaTecnologiaRepositoryMock.Object, _candidatoTecnologiaRepositoryMock.Object);
        }

        [Fact]
        public void DeveRetornarTrueSemVagaVinculada()
        {
            var vagaTecnologia = new VagaTecnologia(1, 1, 20);
            var candidatoTecnologia = new CandidatoTecnologia(1, 1, 20);

            _vagaTecnologiaRepositoryMock.Setup(x => x.BuscaVagaTecnologiaPorTecnologiaId(1));
            _candidatoTecnologiaRepositoryMock.Setup(x => x.BuscarCandidatoTecnologiaPorTecnologiaId(1));

            var resultado = _permitirExclusaoTecnologia.ValidaExclusaoTecnologia(1);
            
            Assert.True(resultado);
        }

        [Fact]
        public void DeveRetornarExceptionComVagaVinculada()
        {
            var vagaTecnologia = new VagaTecnologia(1, 1, 20);
           

            _vagaTecnologiaRepositoryMock.Setup(x => x.BuscaVagaTecnologiaPorTecnologiaId(1)).Returns(vagaTecnologia);
           
            var exception = Assert.Throws<Exception>(() => _permitirExclusaoTecnologia.ValidaExclusaoTecnologia(1));

            Assert.Equal("Tecnologia vinculada a uma vaga, não é possivel a exclusão!", exception.Message);
        }

        [Fact]
        public void DeveRetornarExceptionComTecnologiaVinculada()
        {
            var candidatoTecnologia = new CandidatoTecnologia(1, 1, 20);

            _candidatoTecnologiaRepositoryMock.Setup(x => x.BuscarCandidatoTecnologiaPorTecnologiaId(1)).Returns(candidatoTecnologia);

            var exception = Assert.Throws<Exception>(() => _permitirExclusaoTecnologia.ValidaExclusaoTecnologia(1));

            Assert.Equal("Algum candidato tem está tecnologia vinculada, não é possivel a exlusão!", exception.Message);
        }
    }
}
