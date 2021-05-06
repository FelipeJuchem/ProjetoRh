using RhDomain.Entities.VagasTecnologias;
using RhDomain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhData.Repositories
{
    class VagaTecnologiaRepository : Repository<int, VagaTecnologia>, IVagaTecnologiaRepository
    {
        public VagaTecnologiaRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
