using Moq;
using RhDomain.Dto;
using RhDomain.Entities.Tecnologias;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.UnitOfWork;
using RhDomain.Services.TecnologiaServices;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RhTests.TecnologiaTests
{
    public class TecnologiaAlteradorTests
    {
        private readonly TecnologiaAlterador _tecnologiaAlterador;
        private readonly Mock<ITecnologiaRepository> _tecnologiaRepositoryMock;
        private readonly Mock<IUnitOfWork> _uowMock;

        public TecnologiaAlteradorTests()
        {
            _tecnologiaRepositoryMock = new Mock<ITecnologiaRepository>();
            _uowMock = new Mock<IUnitOfWork>();
            _tecnologiaAlterador = new TecnologiaAlterador(_tecnologiaRepositoryMock.Object, _uowMock.Object);
        }

        [Fact]
        public void DeveAlterarTecnologia()
        {
            var tecnologia = new Tecnologia("Teste1");

            var tecnologiaDto = new TecnologiaDto()
            {
                Descricao = "Teste2"
            };

            _tecnologiaRepositoryMock.Setup(x => x.BuscarPorId(tecnologia.Id)).Returns(tecnologia);

            _tecnologiaAlterador.Alterar(tecnologiaDto);

            Assert.Equal(tecnologiaDto.Descricao, tecnologia.Descricao);
        }

        [Fact]
        public void DeveRetornarExceptionComTecnologiaInvalida()
        {
            var tecnologiaDto = new TecnologiaDto
            {
                Descricao = "",
                Peso = 0
            };

            var resultado = Assert.Throws<Exception>(() => _tecnologiaAlterador.Alterar(tecnologiaDto));

            Assert.Equal("Descrição não pode estar vazia!", resultado.Message);
        }
    }
}
