using Moq;
using RhDomain.Entities.Candidatos;
using RhDomain.Entities.CandidatosTecnologias;
using RhDomain.Entities.Tecnologias;
using RhDomain.Entities.Vagas;
using RhDomain.Interfaces.Repositories;
using RhDomain.Services.VagaTecnologiaServices;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RhTests.VagaTecnologiaTests
{
    public class PermitirExclusaoDeVagaTecnologiaTests
    {
        private readonly Mock<IVagaRepository> _vagaRepositoryMock;
        private readonly PermitirExclusaoDeVagaTecnologia _permitirExclusaoDeVagaTecnologia;
        public PermitirExclusaoDeVagaTecnologiaTests()
        {
            _vagaRepositoryMock = new Mock<IVagaRepository>();
            _permitirExclusaoDeVagaTecnologia = new PermitirExclusaoDeVagaTecnologia(_vagaRepositoryMock.Object);
        }

        [Fact]
        public void DeveRetornarTrueSeVagaExiste()
        {
            
            var vaga = new Vaga("Teste");
            List<Candidato> candidatos = new List<Candidato>();
            vaga.Candidatos = candidatos;
            vaga.Candidatos.Add(new Candidato("Manu", "Doidu", 55, "5555555", 1));
            vaga.Candidatos.Add(new Candidato("Manuas", "Doiduis", 56, "5555555", 2));
            foreach(var candidato in vaga.Candidatos)
            {
                List<CandidatoTecnologia> candidatosTecnologias = new List<CandidatoTecnologia>();
                candidatosTecnologias.Add(new CandidatoTecnologia(1, 2, 30));
                candidatosTecnologias.Add(new CandidatoTecnologia(1, 1, 20));
                candidato.CandidatosTecnologias = candidatosTecnologias;
               foreach(var tecnologia in candidato.CandidatosTecnologias)
                {
                    tecnologia.Tecnologia = new Tecnologia("Teste");
                    
                }
                
            }

            _vagaRepositoryMock.Setup(x => x.BuscaVagaComInclude(1)).Returns(vaga);

            var resultado = _permitirExclusaoDeVagaTecnologia.ValidaExclusaoDeVagaTecnologia(1, 0);

            Assert.True(resultado);
        }

        [Fact]
        public void DeveRetornarFalseSeVagaNaoExiste()
        {

            var vaga = new Vaga("Teste");
            List<Candidato> candidatos = new List<Candidato>();
            vaga.Candidatos = candidatos;
            vaga.Candidatos.Add(new Candidato("Manu", "Doidu", 55, "5555555", 1));
            vaga.Candidatos.Add(new Candidato("Manuas", "Doiduis", 56, "5555555", 2));
            foreach (var candidato in vaga.Candidatos)
            {
                List<CandidatoTecnologia> candidatosTecnologias = new List<CandidatoTecnologia>();
                candidatosTecnologias.Add(new CandidatoTecnologia(1, 2, 30));
                candidatosTecnologias.Add(new CandidatoTecnologia(1, 1, 20));
                candidato.CandidatosTecnologias = candidatosTecnologias;
                foreach (var tecnologia in candidato.CandidatosTecnologias)
                {
                    tecnologia.Tecnologia = new Tecnologia("Teste");

                }

            }

            _vagaRepositoryMock.Setup(x => x.BuscaVagaComInclude(1)).Returns(vaga);

            var resultado = _permitirExclusaoDeVagaTecnologia.ValidaExclusaoDeVagaTecnologia(1, 1);

            Assert.False(resultado);
        }

        [Fact]
        public void DeveRetornarExceptionComVagaNula()
        {
            _vagaRepositoryMock.Setup(x => x.BuscaVagaComInclude(1));

            var exception = Assert.Throws<Exception>(() => _permitirExclusaoDeVagaTecnologia.ValidaExclusaoDeVagaTecnologia(1, 1));

            Assert.Equal("Vaga não existe", exception.Message);
        }
    }
}
