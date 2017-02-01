using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Base interface for implement a "Repository Pattern", for
// more information about this pattern see http://martinfowler.com/eaaCatalog/repository.html
// or http://blogs.msdn.com/adonet/archive/2009/06/16/using-repository-and-unit-of-work-patterns-with-entity-framework-4-0.aspx


namespace Dominio.Seedwork { 

    public interface IRepositorio<TEntity> : IDisposable where TEntity : class
    {
        TEntity Get(string Id);
        IEnumerable<TEntity> GetAll();

        void Add(TEntity item);
        void Remove(TEntity item);


        //IUnitOfWork UnitOfWork { get; }

           
    }
}

