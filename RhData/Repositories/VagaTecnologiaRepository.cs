using RhDomain.Entities.VagasTecnologias;
using RhDomain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace RhData.Repositories
{
    public class VagaTecnologiaRepository : Repository<int, VagaTecnologia>, IVagaTecnologiaRepository
    {
        public VagaTecnologiaRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
