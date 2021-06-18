using Microsoft.EntityFrameworkCore;
using RhDomain.Entities.Candidatos;
using RhDomain.Entities.CandidatosTecnologias;
using RhDomain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RhData.Repositories
{
    public class CandidatoTecnologiaRepository : Repository<int, CandidatoTecnologia>, ICandidatoTecnologiaRepository
    {
        private readonly DataContext _dataContext;
        public CandidatoTecnologiaRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public CandidatoTecnologia BuscarCandidatoTecnologiaporDupoloId(int candidatoId, int tecnologiaId)
        {
            return _dataContext.Set<CandidatoTecnologia>().Find(candidatoId, tecnologiaId);
        }
    }
}
