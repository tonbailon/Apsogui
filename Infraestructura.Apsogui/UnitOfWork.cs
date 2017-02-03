using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Apsogui
{
    public class UnitOfWork : Dominio.Seedwork.IUnitOfWork
    {
        public UnitOfWork()
        {
            Alumnos=new  Infraestructura.Apsogui.Repositorios.RepositorioAlumno();
            
        }
        public Infraestructura.Apsogui.Repositorios.IRepositorioAlumno Alumnos { get; private set; }

        public void AceptarCambios()
        {
            throw new NotImplementedException();
        }
    }        
}
