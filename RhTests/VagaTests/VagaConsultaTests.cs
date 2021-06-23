using AutoMapper;
using Moq;
using RhDomain.Dto;
using RhDomain.Entities.Vagas;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.Services.VagaValidationInterface;
using RhDomain.Interfaces.UnitOfWork;
using RhDomain.Services.VagaServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RhTests.VagaTests
{
    public class VagaConsultaTests
    {
        private readonly Mock<IVagaRepository> _vagaRepositoryMock;
        private readonly VagaConsulta _vagaConsulta;
        private readonly Mock<IVagaValidation> _vagaValidationMock;
        private readonly Mock<IMapper> _mapperMock;
       
        public VagaConsultaTests()
        {
            _vagaRepositoryMock = new Mock<IVagaRepository>();
            _vagaValidationMock = new Mock<IVagaValidation>();
            _mapperMock = new Mock<IMapper>();
            _vagaConsulta = new VagaConsulta(_vagaRepositoryMock.Object, _mapperMock.Object);
        }

        [Fact]
        public async Task DeveRetornarListaDeVagas()
        {
            var experado = new List<Vaga>(){
               new Vaga("teste1"),
               new Vaga("teste2")
            };

            var experadoDto = new List<VagaComTecnologiaECandidatosDto>(){
               new VagaComTecnologiaECandidatosDto(),
               new VagaComTecnologiaECandidatosDto()
            };

            _vagaRepositoryMock.Setup(x => x.BuscarLista()).ReturnsAsync(experado);
            _mapperMock.Setup(x => x.Map<List<VagaComTecnologiaECandidatosDto>>(experado)).Returns(experadoDto);
            var listaDeVagas = await _vagaConsulta.ObterListaDeVagas();

            Assert.Equal(listaDeVagas.Count, 2);
        }
    }
}
