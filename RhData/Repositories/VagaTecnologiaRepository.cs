using RhDomain.Entities.VagasTecnologias;
using RhDomain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhData.Repositories
{
    public class VagaTecnologiaRepository : Repository<int, VagaTecnologia>, IVagaTecnologiaRepository
    {
        private readonly DataContext _dataContext;
        public VagaTecnologiaRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<VagaTecnologia> BuscaVagaTecnologiaPorIdDuplo(int vagaId, int tecnologiaId)
        {
            return await _dataContext.Set<VagaTecnologia>().FindAsync(tecnologiaId, vagaId );
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
