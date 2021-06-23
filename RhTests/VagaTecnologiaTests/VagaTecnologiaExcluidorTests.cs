using Moq;
using RhDomain.Entities.VagasTecnologias;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services;
using RhDomain.Interfaces.UnitOfWork;
using RhDomain.Services.VagaTecnologiaServices;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RhTests.VagaTecnologiaTests
{
    public class VagaTecnologiaExcluidorTests
    {
        private readonly VagaTecnologiaExcluidor _vagaTecnologiaExcluidor;
        private readonly Mock<IPermitirExclusaoDeVagaTecnologia> _permitirExclusaoDeVagaTecnologia;
        private readonly Mock<IUnitOfWork> _IOCMock;
        private readonly Mock<IVagaTecnologiaRepository> _vagaTecnologiaRepository;

        public VagaTecnologiaExcluidorTests()
        {
            _permitirExclusaoDeVagaTecnologia = new Mock<IPermitirExclusaoDeVagaTecnologia>();
            _vagaTecnologiaRepository = new Mock<IVagaTecnologiaRepository>();
            _IOCMock = new Mock<IUnitOfWork>();
            _vagaTecnologiaExcluidor = new VagaTecnologiaExcluidor(_vagaTecnologiaRepository.Object,_IOCMock.Object, _permitirExclusaoDeVagaTecnologia.Object);
        }

        [Fact]
        public void DeveExcluirVagaTecnologia()
        {
            var vagaTecnologia = new VagaTecnologia(1, 1, 20);
            _vagaTecnologiaRepository.Setup(x => x.BuscaVagaTecnologiaPorIdDuplo(1, 1)).Returns(vagaTecnologia);
            _permitirExclusaoDeVagaTecnologia.Setup(x => x.ValidaExclusaoDeVagaTecnologia(1, 1)).Returns(true);
            _vagaTecnologiaExcluidor.Deletar(vagaTecnologia.VagaId, vagaTecnologia.TecnologiaId);
            _vagaTecnologiaRepository.Verify(x => x.Excluir(vagaTecnologia));
        }



    }
}
