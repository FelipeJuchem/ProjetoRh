using RhDomain.Entities.Candidatos;
using RhDomain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhData.Repositories
{
    public class CandidatoRepository : Repository<int, Candidato>, ICandidatoRepository
    {
        public CandidatoRepository(DataContext dataContext) : base(dataContext)
        {

        }


    }
}
