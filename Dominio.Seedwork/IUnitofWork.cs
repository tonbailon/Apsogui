using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Seedwork
{
    public interface IUnitOfWork
    {        
        void AceptarCambios();
        void Rollback();
         
    }
}
