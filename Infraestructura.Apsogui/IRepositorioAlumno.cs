using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Apsogui
{
    public interface IRepositorioAlumno : Dominio.Seedwork.IRepositorio<Dominio.Apsogui.GestionAlumnos.Alumno>

    {
        void AlumnosLicenciaCaducada(DateTime fechaExamen, int DiasMargenDelante, int DiasMargenDetras);

    }
}
