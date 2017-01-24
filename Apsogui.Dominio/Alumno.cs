using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apsogui.Dominio
{
    public class Alumno
    {
        public Alumno() {

        }

        public string IdAlumno { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string TipoIdentificacion { get; set; }
        public DateTime FechaNacimiento { get; set; }        
                
    }
}
