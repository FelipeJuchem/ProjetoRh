using Microsoft.AspNetCore.Mvc;
using RhDomain.Dto;
using RhDomain.Entities.Tecnologias;
using RhDomain.Entities.Vagas;
using RhDomain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RhAPI.Controllers.VagasController
{
    [Route("api/[controller]")]
    [ApiController]
    public class VagasController : Controller
    {
        private readonly IVagaConsulta _vagaConsulta;
        private readonly IVagaArmazenador _vagaArmazenador;
        private readonly IVagaAlterador _vagaAlterador;
        private readonly IVagaExcluidor _vagaExcluidor;

        public VagasController(IVagaArmazenador vagaArmazenador, IVagaConsulta vagaConsulta, IVagaAlterador vagaAlterador,
            IVagaExcluidor vagaExcluidor)
        {
            _vagaConsulta = vagaConsulta;
            _vagaArmazenador = vagaArmazenador;
            _vagaAlterador = vagaAlterador;
            _vagaExcluidor = vagaExcluidor;
        }
        [HttpPost]
        public ActionResult<VagaComTecnologiaECandidatosDto> Post([FromBody] VagaComTecnologiaECandidatosDto vagaDto)
        {
            try
            {
                return _vagaArmazenador.IncluirVaga(vagaDto);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }

        [HttpGet]
        public async Task<List<VagaComTecnologiaECandidatosDto>> Get()
        {
            return await _vagaConsulta.ObterListaDeVagas();
        }

        [HttpGet("{id}")]
        public ActionResult<VagaComTecnologiaECandidatosDto> Get(int id)
        {
            return _vagaConsulta.ObterVagaComTecnologiaPorId(id);
        }

        [HttpGet("GetTeste/{id}")]
        public ActionResult<VagaComTecnologiaECandidatosDto> GetTeste(int id)
        {
            return _vagaConsulta.ObterVagaComTecnologiaPorId(id);
        }

        [HttpGet("GetVagasComCandidatosSorteados/{id}")]
        public ActionResult<VagaComCandidatoDtoSorteado> GetVagaComCandidatoSorteado(int id)
        {
            return _vagaConsulta.ObterVagaComCandidatoSorteadoPorId(id);
        }

        [HttpPut]
        public ActionResult<VagaComTecnologiaECandidatosDto> Put(VagaComTecnologiaECandidatosDto vagaDto)
        {
            try
            {
                return _vagaAlterador.Alterar(vagaDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _vagaExcluidor.ExcluirVagaPeloId(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        

    }
}
