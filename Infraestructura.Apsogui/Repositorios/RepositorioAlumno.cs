using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Apsogui.GestionAlumnos;
using System.Data.Entity;

namespace Infraestructura.Data.Apsogui.Repositorios
{
    class RepositorioAlumno : Dominio.Seedwork.IRepositorio<Alumno>, Dominio.Apsogui.GestionAlumnos.IRepositorioAlumno
    {

        private Dominio.Seedwork.IUnitOfWork m_UnitOfWork;
        public RepositorioAlumno(Dominio.Seedwork.IUnitOfWork UnitOfWork) {
            m_UnitOfWork = UnitOfWork;
            }
       
        public void Add(Alumno item)
        {
            throw new NotImplementedException();
        }

        public void AlumnosLicenciaCaducada(DateTime fechaExamen, int DiasMargenDelante, int DiasMargenDetras)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Alumno Get(string Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Alumno> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(Alumno item)
        {
            throw new NotImplementedException();
        }
    }
}
