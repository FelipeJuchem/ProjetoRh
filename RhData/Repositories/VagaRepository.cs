using Microsoft.EntityFrameworkCore;
using RhDomain.Entities.Tecnologias;
using RhDomain.Entities.Vagas;
using RhDomain.Entities.VagasTecnologias;
using RhDomain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RhData.Repositories
{
    public class VagaRepository : Repository<int, Vaga>, IVagaRepository
    {
        private readonly DataContext _dataContext;
        public VagaRepository(DataContext dataContext) : base (dataContext)
        {
            _dataContext = dataContext;
        }

        public Vaga BuscaVagaComInclude(int id)
        {
            return _dataContext.Set<Vaga>()
                .Where(x => x.Id == id)
                .Include(y => y.VagasTecnologias)
                .ThenInclude(l => l.Tecnologia)
                .FirstOrDefault();
        }
    }
}
