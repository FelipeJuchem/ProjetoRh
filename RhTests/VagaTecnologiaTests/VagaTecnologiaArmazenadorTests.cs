using Moq;
using RhDomain.Dto;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.UnitOfWork;
using RhDomain.Services.VagaTecnologiaServices;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RhTests.VagaTecnologiaTests
{
    public class VagaTecnologiaArmazenadorTests
    {
        private readonly VagaTecnologiaArmazenador _vagaTecnologiaArmazenador;
        private readonly Mock<IVagaTecnologiaRepository> _vagaTecnologiaRepositoryMock;
        private readonly Mock<IUnitOfWork> _uowMock;

        public VagaTecnologiaArmazenadorTests()
        {
            _uowMock = new Mock<IUnitOfWork>();
            _vagaTecnologiaRepositoryMock = new Mock<IVagaTecnologiaRepository>();
            _vagaTecnologiaArmazenador = new VagaTecnologiaArmazenador(_vagaTecnologiaRepositoryMock.Object, _uowMock.Object);
        }

        [Fact]
        public void DeveArmazenadorVagaTecnologia()
        {
            var vagaTecnologiaDto = new VagaTecnologiaDto
            {
                Peso = 15,
                VagaId = 1,
                TecnologiaId = 2
            };

            var resultado = _vagaTecnologiaArmazenador.IncluirVagaTecnologia(vagaTecnologiaDto);

            Assert.NotNull(resultado);
        }


    }
}
