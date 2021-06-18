using Microsoft.AspNetCore.Mvc;
using RhDomain.Dto;
using RhDomain.Interfaces.Services;
using RhDomain.Interfaces.Services.CandidatoTecnologiaValidations;
using RhDomain.Services.VagaTecnologiaServices;
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
        
        private readonly IVagaTecnologiaExcluidor _vagaTecnologiaExcluidor;
        private readonly IVagaTecnologiaArmazenador _vagaTecnologiaArmazenador;
        private readonly IVagaTecnologiaConsulta _vagaTecnologiaConsulta;

        public VagaTecnologiaController(IVagaTecnologiaArmazenador vagaTecnologiaArmazenador, IVagaTecnologiaConsulta vagaTecnologiaConsulta,
            IVagaTecnologiaExcluidor vagaTecnologiaExcluidor)
        {
            _vagaTecnologiaExcluidor = vagaTecnologiaExcluidor;
            _vagaTecnologiaArmazenador = vagaTecnologiaArmazenador;
            _vagaTecnologiaConsulta = vagaTecnologiaConsulta;
            
        }

        [HttpPost]
        public ActionResult<VagaTecnologiaDto> Post([FromBody] VagaTecnologiaDto vagaTecnologiaDto)
        {
            return _vagaTecnologiaArmazenador.IncluirVagaTecnologia(vagaTecnologiaDto);
        }

        [HttpGet]
        public async Task<List<VagaTecnologiaDto>> Get()
        {
            return await _vagaTecnologiaConsulta.BuscarListaVagaTecnologia();
        }

        [HttpGet("{vagaId}/{tecnologiaId}")]
        public VagaTecnologiaDto Get(int vagaId, int tecnologiaId)
        {
            return _vagaTecnologiaConsulta.BuscaVagaTecnologiaPorId(vagaId, tecnologiaId);
        }

        [HttpDelete("{vagaId}/{tecnologiaId}")]
        public async Task<ActionResult> Delete(int vagaId, int tecnologiaId)
        {
            try
            {
                var resultado = await _vagaTecnologiaExcluidor.Deletar(vagaId, tecnologiaId);
                if (resultado)
                {
                    return Ok();
                }
                return BadRequest("Não é possivel desvincular a tecnologia, algum candidato da vaga esta com a tecnologia vinculada, desvincule a tecnologia da vaga para desvincular a tecnologia da Vaga!");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
