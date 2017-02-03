using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Apsogui.GestionAlumnos;
using System.Data.Entity;

namespace Infraestructura.Apsogui.Repositorios
{
    class RepositorioAlumno : Dominio.Seedwork.RepositorioDbContext<Alumno>, IRepositorioAlumno
    {
       
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
