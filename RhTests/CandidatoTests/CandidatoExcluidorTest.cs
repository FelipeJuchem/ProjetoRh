using AutoMapper;
using Moq;
using RhDomain.Dto;
using RhDomain.Entities.Candidatos;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services;
using RhDomain.Interfaces.Services.CandidatoValidationInterface;
using RhDomain.Interfaces.UnitOfWork;
using RhDomain.Services.CandidatoServices;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RhTests
{
    public class CandidatoExcluidorTest
    {
        private readonly CandidatoExcluidor _candidatoExcluidorMock;
        private readonly Mock<ICandidatoRepository> _candidatoRepositoryMock;
        private readonly Mock<IUnitOfWork> _IOCMock;

        public CandidatoExcluidorTest()
        {
            _IOCMock = new Mock<IUnitOfWork>();
            _candidatoRepositoryMock = new Mock<ICandidatoRepository>();
            _candidatoExcluidorMock = new CandidatoExcluidor(_candidatoRepositoryMock.Object, _IOCMock.Object);
        }

        [Fact]
        public void DeveDeletarCandidato()
        {
            var candidato = new Candidato("Manu", "Sobremanu", 18, "515-151-15", 1);
            _candidatoRepositoryMock.Setup(x => x.BuscarPorId(1)).Returns(candidato);
            _candidatoExcluidorMock.ExcluirCandidatoPeloId(1);
            _candidatoRepositoryMock.Verify(x => x.Excluir(candidato));
        }

        [Fact]
        public void NaoDeveExcluirQuandoNaoEncontrarCandidato()
        {
            var candidato = new Candidato("Manu", "Sobremanu", 18, "515-151-15", 1);
            _candidatoRepositoryMock.Setup(x => x.BuscarPorId(1)).Returns(candidato);
            _candidatoExcluidorMock.ExcluirCandidatoPeloId(2);
            _candidatoRepositoryMock.Verify(x => x.Excluir(candidato), Times.Never());
        }
        
        [Fact]
        public void DeveChamarExcluirUmaVez()
        {
            var candidato = new Candidato("Manu", "Sobremanu", 18, "515-151-15", 1);
            _candidatoRepositoryMock.Setup(x => x.BuscarPorId(1)).Returns(candidato);
            _candidatoExcluidorMock.ExcluirCandidatoPeloId(1);
            _candidatoRepositoryMock.Verify(x => x.Excluir(candidato), Times.Once);
        }
    }
}
