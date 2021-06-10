using RhDomain.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RhDomain.Interfaces.Services
{
    public interface ITecnologiaConsulta
    {
        Task<List<TecnologiaDto>> ObterListaDeTecnologias();

        TecnologiaDto ObterTecnologiaPorId(int id);


    }
}
