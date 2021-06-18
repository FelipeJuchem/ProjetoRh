using Microsoft.EntityFrameworkCore;
using RhDomain.Dto;
using RhDomain.Entities.Candidatos;
using RhDomain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhData.Repositories
{
    public class CandidatoRepository : Repository<int, Candidato>, ICandidatoRepository
    {
        private readonly DataContext _dataContext;
        public CandidatoRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public  Candidato BuscaCandidatoTecnologiaComTecnologias(int id)
        {
            return _dataContext.Candidato
                .Where(x => x.Id == id).Include(o => o.CandidatosTecnologias)
                .ThenInclude(p => p.Tecnologia)
                .ThenInclude(t => t.VagasTecnologias)
                .FirstOrDefault();
        }

        public Candidato BuscarParaArmazenarCandidatoTecnologia(CandidatoComTecnologiaParaArmazenarDto candidatoComTecnologiaParaArmazenarDto)
        {
            return _dataContext.Candidato
                .Include(x => x.Vaga)
                .ThenInclude(p => p.VagasTecnologias)
                .FirstOrDefault(x => x.Id == candidatoComTecnologiaParaArmazenarDto.CandidatoId 
                && x.VagaId == candidatoComTecnologiaParaArmazenarDto.VagaId
                && x.Vaga.VagasTecnologias.Any(o => o.TecnologiaId == candidatoComTecnologiaParaArmazenarDto.TecnologiaId));
        }

        public async Task<List<Candidato>> BuscarListaCandidatosComVagaDescricao()
        {
            return await _dataContext.Candidato.Include(x => x.Vaga).ToListAsync();
        } 
    }
}
