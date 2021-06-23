using Moq;
using RhDomain.Entities.CandidatosTecnologias;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.UnitOfWork;
using RhDomain.Services.CandidatoTecnologiaServices;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RhTests.CandidatoTecnologiaTests
{
    public class CandidatoTecnologiaExcluidorTests
    {
        private readonly CandidatoTecnologiaExcluidor _candidatoTecnologiaExcluidor;
        private readonly Mock<IUnitOfWork> _IOCMock;
        private readonly Mock<ICandidatoTecnologiaRepository> _candidatotecnologiaRepositoryMock;

        public CandidatoTecnologiaExcluidorTests()
        {
            _candidatotecnologiaRepositoryMock = new Mock<ICandidatoTecnologiaRepository>();
            _IOCMock = new Mock<IUnitOfWork>();
            _candidatoTecnologiaExcluidor = new CandidatoTecnologiaExcluidor(_candidatotecnologiaRepositoryMock.Object, _IOCMock.Object);
        }

        [Fact]
        public void DeveExcluirCandidatoTecnologia()
        {
            var candidatoTecnologia = new CandidatoTecnologia(1, 1, 20);
            _candidatotecnologiaRepositoryMock.Setup(x => x.BuscarCandidatoTecnologiaporDuploId(1, 1)).Returns(candidatoTecnologia);
            _candidatoTecnologiaExcluidor.Deletar(1, 1);
            _candidatotecnologiaRepositoryMock.Verify(x => x.Excluir(candidatoTecnologia));
        }


    }
}
