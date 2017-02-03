using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.EntityClient;
using System.Data.Entity;

namespace Dominio.Seedwork
{
    class RepositorioDbContext<TEntity> : Dominio.Seedwork.IRepositorio<TEntity> where TEntity : class
    {

        protected readonly DbContext m_context;

        RepositorioDbContext()
        {
            
        }

        TEntity IRepositorio<TEntity>.Get(string Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<TEntity> IRepositorio<TEntity>.GetAll()
        {
            throw new NotImplementedException();
        }

        void IRepositorio<TEntity>.Add(TEntity item)
        {
            throw new NotImplementedException();
        }

		void IRepositorio<TEntity>.Remove(TEntity item)
        {
            throw new NotImplementedException();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
