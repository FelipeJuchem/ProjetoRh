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
        private readonly ICandidatoConsulta _candidatoConsulta;
        private readonly ICandidatoArmazenador _candidatoArmazenador;

        public CandidatosController(ICandidatoConsulta candidatoConsulta, ICandidatoArmazenador candidatoArmazenador)
        {
            _candidatoConsulta = candidatoConsulta;
            _candidatoArmazenador = candidatoArmazenador;
        }

        [HttpGet]
        public async Task<ActionResult<List<CandidatoDto>>> Get()
        {
            return _candidatoConsulta.ObterListaCandidatos();
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

    }
}
