using Microsoft.EntityFrameworkCore;
using RhDomain.Interfaces.Repositories;
using RhDomain.Interfaces.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public List<TEntity> BuscarLista()
        {
            return _dbSet.ToList();
        }

        public TEntity Alterador(TEntity objeto)
        {
            _dbSet.Update(objeto);
            return objeto;
        }
    }
}
