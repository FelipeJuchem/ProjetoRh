using Microsoft.AspNetCore.Mvc;
using RhDomain.Dto;
using RhDomain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RhAPI.Controllers.VagaTecnologiaController
{
    [Route("api/[controller]")]
    [ApiController]

    public class VagaTecnologiaController : Controller
    {
        private readonly IVagaTecnologiaArmazenador _vagaTecnologiaArmazenador;

        public VagaTecnologiaController(IVagaTecnologiaArmazenador vagaTecnologiaArmazenador)
        {
            _vagaTecnologiaArmazenador = vagaTecnologiaArmazenador;
        }

        [HttpPost]
        public ActionResult<VagaTecnologiaDto> Post([FromBody] VagaTecnologiaDto vagaTecnologiaDto)
        {
            return _vagaTecnologiaArmazenador.IncluirVagaTecnologia(vagaTecnologiaDto);
        }
    }
}
