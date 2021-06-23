using Microsoft.AspNetCore.Mvc;
using RhDomain.Dto;
using RhDomain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RhAPI.Controllers.CandidatoTecnologiaController
{

    [Route("api/[controller]")]
    [ApiController]
    public class CandidatoTecnologiaController : Controller
    {
        private readonly ICandidatoTecnologiaArmazenador _candidatoTecnologiaArmazenador;
        private readonly ICandidatoTecnologiaConsulta _candidatoTecnologiaConsulta;
        private readonly ICandidatoTecnologiaExcluidor _candidatoTecnologiaExcluidor;

        public CandidatoTecnologiaController(ICandidatoTecnologiaArmazenador candidatoTecnologiaArmazenador,
            ICandidatoTecnologiaConsulta candidatoTecnologiaConsulta, ICandidatoTecnologiaExcluidor candidatoTecnologiaExcluidor)
        {
            _candidatoTecnologiaArmazenador = candidatoTecnologiaArmazenador;
            _candidatoTecnologiaConsulta = candidatoTecnologiaConsulta;
            _candidatoTecnologiaExcluidor = candidatoTecnologiaExcluidor;
        }

        [HttpPost]
        public async Task<ActionResult<CandidatoTecnologiaDto>> Post([FromBody] CandidatoTecnologiaDto candidatoTecnologiaDto)
        {
            try
            {
                return await _candidatoTecnologiaArmazenador.IncluirCandidatoTecnologia(candidatoTecnologiaDto);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

           
        }

        [HttpGet]
        public async Task<ActionResult<List<CandidatoTecnologiaDto>>> Get()
        {
            return await _candidatoTecnologiaConsulta.BuscarListaCandidatoTecnologia();
        }

        [HttpGet("{candidatoId}/{tecnologiaId}")]
        public CandidatoTecnologiaDto Get(int candidatoId, int tecnologiaId)
        {
            return _candidatoTecnologiaConsulta.BuscarPorIdDuplo(candidatoId, tecnologiaId);
        }

        [HttpDelete("{candidatoId}/{tecnologiaId}")]
        public void Delete(int candidatoId, int tecnologiaId)
        {
            _candidatoTecnologiaExcluidor.Deletar(candidatoId, tecnologiaId);
        }
    }
}
