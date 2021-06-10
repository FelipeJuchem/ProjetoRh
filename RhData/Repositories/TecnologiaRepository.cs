using RhDomain.Entities.Tecnologias;
using RhDomain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RhData.Repositories
{
    public class TecnologiaRepository : Repository<int, Tecnologia>, ITecnologiaRepository
    {
        public TecnologiaRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
