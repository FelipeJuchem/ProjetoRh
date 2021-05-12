using RhDomain.Dto;
using RhDomain.Entities.Vagas;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhDomain.Interfaces.Services
{
    public interface IVagaConsulta
    {
        List<VagaDto> ObterListaDeVagas();
        VagaDto ObterVagaPorId(int id);
    }
}
