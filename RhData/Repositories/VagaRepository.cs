using RhDomain.Entities.Vagas;
using RhDomain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhData.Repositories
{
    public class VagaRepository : Repository<int, Vaga>, IVagaRepository
    {
        public VagaRepository(DataContext dataContext) : base (dataContext)
        {

        }


    }
}
