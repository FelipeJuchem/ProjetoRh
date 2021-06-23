using Microsoft.AspNetCore.Mvc;
using RhDomain.Dto;
using RhDomain.Entities.Candidatos;
using RhDomain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RhAPI.Controllers.CandidatosController
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatosController : Controller
    {
        private readonly ICandidatoExcluidor _candidatoExcluidor;
        private readonly ICandidatoConsulta _candidatoConsulta;
        private readonly ICandidatoArmazenador _candidatoArmazenador;
        private readonly ICandidatoAlterador _candidatoAlterador;

        public CandidatosController(ICandidatoConsulta candidatoConsulta, ICandidatoArmazenador candidatoArmazenador,
            ICandidatoExcluidor candidatoExcluidor, ICandidatoAlterador candidatoAlterador)
        {
            _candidatoExcluidor = candidatoExcluidor;
            _candidatoConsulta = candidatoConsulta;
            _candidatoArmazenador = candidatoArmazenador;
            _candidatoAlterador = candidatoAlterador;
        }

        [HttpGet("candidatoETecnologia/{id}")]
        public ActionResult<CandidatoComTecnologiaDto> Get(int id)
        {
            return _candidatoConsulta.ObterCandidatoComTecnologia(id);
        }


        [HttpGet]
        public async Task<ActionResult<List<CandidatoDto>>> Get()
        {
            try
            {
                return await _candidatoConsulta.ObterListaCandidatos();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }

        [HttpGet("{id}")]
        public ActionResult<CandidatoDto> GetById(int id)
        {
            try
            {
                return _candidatoConsulta.ObterPorId(id);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }

        [HttpPost]
        public ActionResult<CandidatoDto> Post([FromBody] CandidatoDto candidatoDto)
        {
            try
            {
                return _candidatoArmazenador.IncluirCandidato(candidatoDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpPut]
        public ActionResult<CandidatoDto> Put(CandidatoDto candidatoDto)
        {
            try
            {
                return _candidatoAlterador.Alterar(candidatoDto);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _candidatoExcluidor.ExcluirCandidatoPeloId(id);
        }
}
}
