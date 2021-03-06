using Microsoft.AspNetCore.Mvc;
using RhDomain.Dto;
using RhDomain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RhAPI.Controllers.TecnologiaController
{
    [Route("api/[controller]")]
    [ApiController]
    public class TecnologiaController : Controller
    {
        private readonly ITecnologiaArmazenador _tecnologiaArmazenador;
        private readonly ITecnologiaConsulta _tecnologiaConsulta;
        private readonly ITecnologiaExcluidor _tecnologiaExcluidor;
        private readonly ITecnologiaAlterador _tecnologiaAlterador;

        public TecnologiaController(ITecnologiaArmazenador tecnologiaArmazenador, ITecnologiaConsulta tecnologiaConsulta,
            ITecnologiaExcluidor tecnologiaExcluidor, ITecnologiaAlterador tecnologiaAlterador)
        {
            _tecnologiaArmazenador = tecnologiaArmazenador;
            _tecnologiaConsulta = tecnologiaConsulta;
            _tecnologiaExcluidor = tecnologiaExcluidor;
            _tecnologiaAlterador = tecnologiaAlterador;
        }

        [HttpPost]
        public ActionResult<TecnologiaDto> Post([FromBody] TecnologiaDto tecnologiaDto)
        {
            try
            {
                return _tecnologiaArmazenador.IncluirTecnologia(tecnologiaDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpGet]
        public async Task<ActionResult<List<TecnologiaDto>>> Get()
        {
            try
            {
                return await _tecnologiaConsulta.ObterListaDeTecnologias();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpGet("{id}")]
        public TecnologiaDto GetById(int id)
        {
            return _tecnologiaConsulta.ObterTecnologiaPorId(id);
        }

        [HttpDelete("{id}")]
        public ActionResult Excluir(int id)
        {
            try
            {
                _tecnologiaExcluidor.ExcluirTecnologia(id);
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        [HttpPut]
        public ActionResult<TecnologiaDto> Put(TecnologiaDto tecnologiaDto)
        {
            try
            {
                return _tecnologiaAlterador.Alterar(tecnologiaDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

    }
}
