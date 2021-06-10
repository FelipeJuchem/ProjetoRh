using RhDomain.Dto;
using RhDomain.Entities.Tecnologias;
using RhDomain.Entities.Vagas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RhDomain.Interfaces.Services
{
    public interface IVagaConsulta
    {
        Task<List<VagaComTecnologiaDto>> ObterListaDeVagas();
        VagaComTecnologiaDto ObterVagaComTecnologiaPorId(int id);

    }
}
