using Moq;
using RhDomain.Entities.Tecnologias;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services;
using RhDomain.Interfaces.UnitOfWork;
using RhDomain.Services.TecnologiaServices;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RhTests.TecnologiaTests
{
    public class TecnologiaExcluidorTests
    {
        private readonly Mock<IPermitirExclusaoTecnologia> _permitirExclusaoTecnologiaMock;
        private readonly TecnologiaExcluidor _tecnologiaExcluidorMock;
        private readonly Mock<ITecnologiaRepository> _tecnologiaRepositoryMock;
        private readonly Mock<IUnitOfWork> _IOCMock;
        

        public TecnologiaExcluidorTests()
        {
            _IOCMock = new Mock<IUnitOfWork>();
            _tecnologiaRepositoryMock = new Mock<ITecnologiaRepository>();
            _permitirExclusaoTecnologiaMock = new Mock<IPermitirExclusaoTecnologia>();
            _tecnologiaExcluidorMock = new TecnologiaExcluidor(_tecnologiaRepositoryMock.Object, _IOCMock.Object, _permitirExclusaoTecnologiaMock.Object);
        }

        [Fact]
        public void DeveDeletarTecnologia()
        {
            var tecnologia = new Tecnologia("Desenvolvedor");
            _tecnologiaRepositoryMock.Setup(x => x.BuscarPorId(1)).Returns(tecnologia);
            _permitirExclusaoTecnologiaMock.Setup(x => x.ValidaExclusaoTecnologia(1)).Returns(true);
            _tecnologiaExcluidorMock.ExcluirTecnologia(1);
            _tecnologiaRepositoryMock.Verify(x => x.Excluir(tecnologia));
        }




    }
}
