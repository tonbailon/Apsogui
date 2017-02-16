using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Apsogui.GestionAlumnos.Agregados
{
    public interface IRepositorioAlumno : Dominio.Seedwork.IRepositorio<Dominio.Apsogui.GestionAlumnos.Agregados.Alumno>

    {
        void AlumnosLicenciaCaducada(DateTime fechaExamen, int DiasMargenDelante, int DiasMargenDetras);

    }
}
