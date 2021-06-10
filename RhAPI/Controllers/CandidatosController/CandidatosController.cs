using Microsoft.AspNetCore.Mvc;
using RhDomain.Dto;
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

        [HttpGet]
        public async Task<ActionResult<List<CandidatoDto>>> Get()
        {
            return await _candidatoConsulta.ObterListaCandidatos();
        }

        [HttpGet("{id}")]
        public ActionResult<CandidatoDto> Get(int id)
        {
            return _candidatoConsulta.ObterPorId(id);
        }

        [HttpPost]
        public ActionResult<CandidatoDto> Post([FromBody] CandidatoDto candidatoDto)
        {
            return _candidatoArmazenador.IncluirCandidato(candidatoDto);
        }

        [HttpPut]
        public ActionResult<CandidatoDto> Put(CandidatoDto candidatoDto)
        {
            return _candidatoAlterador.Alterar(candidatoDto);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _candidatoExcluidor.ExcluirCandidatoPeloId(id);
        }
    }
}
