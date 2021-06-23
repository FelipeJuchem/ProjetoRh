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

        public void Armazenar(TEntity obj)
        {
            _dbSet.Add(obj);
        }

        public void Excluir(TEntity obj)
        {
            _dbSet.Remove(obj);
        }

        public TEntity BuscarPorId(TId Id)
        {
            return _dbSet.Find(Id);
        }

        public async Task<List<TEntity>> BuscarLista()
        {
            return await _dbSet.ToListAsync();
        }

        public TEntity Alterador(TEntity obj)
        {
            _dbSet.Update(obj);
            return obj;
        }
    }
}
