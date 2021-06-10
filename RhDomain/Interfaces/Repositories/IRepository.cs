using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RhDomain.Interfaces.Repositories
{
    public interface IRepository<TId, TEntity>
        where TId : struct
        where TEntity : class
    {
        void Armazenar(TEntity obj);

        void Excluir(TEntity obj);

        TEntity BuscarPorId(TId Id);

        Task<List<TEntity>> BuscarLista();

        TEntity Alterador(TEntity obj);
    }
}
