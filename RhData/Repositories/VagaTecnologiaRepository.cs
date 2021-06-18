using RhDomain.Entities.VagasTecnologias;
using RhDomain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RhData.Repositories
{
    public class VagaTecnologiaRepository : Repository<int, VagaTecnologia>, IVagaTecnologiaRepository
    {
        private readonly DataContext _dataContext;
        public VagaTecnologiaRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public VagaTecnologia BuscaVagaTecnologiaPorIdDuplo(int vagaId, int tecnologiaId)
        {
            return _dataContext.Set<VagaTecnologia>().Find(tecnologiaId, vagaId );
        }

        public VagaTecnologia BuscaVagaTecnologiaPorTecnologiaId(int tecnologiaId)
        {
            return _dataContext.Set<VagaTecnologia>().FirstOrDefault(x => x.TecnologiaId == tecnologiaId);
        }

        public VagaTecnologia BuscaVagaTecnologiaPorVagaId(int vagaId)
        {
            return _dataContext.Set<VagaTecnologia>().FirstOrDefault(x => x.VagaId == vagaId);
        }
    }
}
