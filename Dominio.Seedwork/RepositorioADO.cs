﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Seedwork
{
    class RepositorioADO<TEntity> : Dominio.Seedwork.IRepositorio<TEntity> where TEntity : class
    {
        protected readonly ADOCONTEXT?? m_context;

        public TEntity Get(string Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity item)
        {
            throw new NotImplementedException();
        }
        public void Add(TEntity item)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
        
    }
}
