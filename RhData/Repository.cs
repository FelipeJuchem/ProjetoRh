using Microsoft.EntityFrameworkCore;
using RhDomain.Dto;
using RhDomain.Entities.Vagas;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhData
{
    public class Repository<TId, TEntity> : IRepository<TId, TEntity>
        where TId : struct
        where TEntity : class
    {
        private readonly DbSet<TEntity> _dbSet;
        private readonly DataContext _dataContext;
        
        public Repository(DataContext dataContext)
        {
            _dataContext = dataContext;
            _dbSet = _dataContext.Set<TEntity>();
        }

        public void Armazenar(TEntity objeto)
        {
            _dbSet.Add(objeto);
        }

        public void Excluir(TEntity objeto)
        {
            _dbSet.Remove(objeto);
        }

        public TEntity BuscarPorId(TId id)
        {
            return _dbSet.Find(id);
        }

        public async Task<List<TEntity>> BuscarLista()
        {
            return await _dbSet.ToListAsync();
        }

        public TEntity Alterador(TEntity objeto)
        {
            _dbSet.Update(objeto);
            return objeto;
        }
    }
}
