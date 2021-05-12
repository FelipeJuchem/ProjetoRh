using Microsoft.AspNetCore.Mvc;
using RhDomain.Dto;
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

        public VagasController(IVagaArmazenador vagaArmazenador, IVagaConsulta vagaConsulta)
        {
            _vagaConsulta = vagaConsulta;
            _vagaArmazenador = vagaArmazenador;
        }
        [HttpPost]
        public ActionResult<VagaDto> Post([FromBody] VagaDto vagaDto)
        {
            return _vagaArmazenador.IncluirVaga(vagaDto);
        }

        [HttpGet]
        public async Task<List<VagaDto>> Get()
        {
            return _vagaConsulta.ObterListaDeVagas();
        }

    }
}
