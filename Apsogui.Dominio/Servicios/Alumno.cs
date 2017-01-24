using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Apsogui
{
    public class Alumno
    {

        private string m_IdAlumno="";
        private string m_Nombre = "";
        private string m_Apellido1="";
        private string m_Apellido2 ="";
        private string m_NumeroIdentificacion = "";
        private string m_TipoIdentificacion = "";
        private DateTime? m_FechaNacimiento = null;

        public Alumno() {

        }

        public string IdAlumno { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string TipoIdentificacion { get; set; }
        public DateTime FechaNacimiento { get; set; }        
                
        public string SituacionAlumnoAltaOBaja() {
            throw new NotImplementedException("Dominio.Appsogui.SituacionAlumnoAltaOBaja");
        }
        void BajaAlumno()
        {
            throw new NotImplementedException("Dominio.Appsogui.BajaAlumno");
        }

        void ReactivarAlumno()
        {
            throw new NotImplementedException("Dominio.Appsogui.ReactivarAlumno");
        }

        void AddCinturon(Cinturon cinturon)
        {
            if (cinturon == null)   { throw new ArgumentException("Cinturon"); }

        }
    }
}
