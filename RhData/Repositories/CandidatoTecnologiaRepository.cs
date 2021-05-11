using RhDomain.Entities.CandidatosTecnologias;
using RhDomain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhData.Repositories
{
    public class CandidatoTecnologiaRepository : Repository<int, CandidatoTecnologia>, ICandidatoTecnologiaRepository
    {
        public CandidatoTecnologiaRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
