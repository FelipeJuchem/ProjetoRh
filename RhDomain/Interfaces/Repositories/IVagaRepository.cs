using RhDomain.Entities.Tecnologias;
using RhDomain.Entities.Vagas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RhDomain.Interfaces.Repositories
{
    public interface IVagaRepository : IRepository<int, Vaga>
    {
        Vaga BuscaVagaComInclude(int id);
    }
}
