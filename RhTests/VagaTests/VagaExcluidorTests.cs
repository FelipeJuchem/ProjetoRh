using Moq;
using RhDomain.Entities.Vagas;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.UnitOfWork;
using RhDomain.Services.VagaServices;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RhTests.VagaTests
{
    public class VagaExcluidorTests
    {
        private readonly VagaExcluidor _vagaExcluidorMock;
        private readonly Mock<IVagaRepository> _vagaRepositoryMock;
        private readonly Mock<IUnitOfWork> _IOCMock;

        public VagaExcluidorTests()
        {
            _IOCMock = new Mock<IUnitOfWork>();
            _vagaRepositoryMock = new Mock<IVagaRepository>();
            _vagaExcluidorMock = new VagaExcluidor(_vagaRepositoryMock.Object, _IOCMock.Object);
        }

        [Fact]
        public void DeveDeletarVaga()
        {
            var vaga = new Vaga("desenvolvedor");
            _vagaRepositoryMock.Setup(x => x.BuscarPorId(1)).Returns(vaga);
            _vagaExcluidorMock.ExcluirVagaPeloId(1);
            _vagaRepositoryMock.Verify(x => x.Excluir(vaga));
        }


            
            
        
    }   
}
