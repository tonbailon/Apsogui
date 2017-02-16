using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Apsogui.GestionAlumnos.Agregados
{
    public class Alumno
    {

        #region "Miembros"
        //private string m_IdAlumno="";
        //private string m_Nombre = "";
        //private string m_Apellido1="";
        //private string m_Apellido2 ="";
        //private string m_NumeroIdentificacion = "";
        //private string m_TipoIdentificacion = "";
        //private DateTime? m_FechaNacimiento = null;

        private bool m_Indbaja;
        private List<Dominio.Apsogui.GestionAlumnos.Agregados.CinturonGimnasio> m_Cinturones;
        private List<Dominio.Apsogui.GestionAlumnos.Agregados.Licencia> m_Licencias;
        private List<Dominio.Apsogui.GestionAlumnos.Agregados.MovimientoAlumno> m_AltasBajas;

        private Dominio.Apsogui.GestionAlumnos.Agregados.MovimientoAlumno m_UltimoMovimiento;
        #endregion

        #region "Constructor"

        public Alumno() {
            this.m_Cinturones = new List<Dominio.Apsogui.GestionAlumnos.Agregados.CinturonGimnasio>();
            this.m_Licencias= new List<Dominio.Apsogui.GestionAlumnos.Agregados.Licencia>();
            this.m_AltasBajas= new List<Dominio.Apsogui.GestionAlumnos.Agregados.MovimientoAlumno>();
            this.m_Indbaja = false;
            //this.m_UltimoMovimiento = new Dominio.Apsogui.GestionAlumnos.Agregados.MovimientoAlumno( MovimientoAlumno.TipoMovimiento.Alta,DateTime.Now);
    }

        #endregion

        #region "Propiedades"
        public Guid IdAlumno { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string TipoIdentificacion { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public eSituacionAlumno getSituacionAltaOBaja()
        {
            if (m_Indbaja)
            {
                return eSituacionAlumno.Baja;
            }
            else
            {
                return eSituacionAlumno.Alta;
            }
        }

        public List<Dominio.Apsogui.GestionAlumnos.Agregados.CinturonGimnasio> Cinturones {
            get
            {
                return this.m_Cinturones;
            }
            set
            {
                this.m_Cinturones = value;
            }
        }
                    
        #endregion

        #region "Métodos"


        void setBaja(DateTime FechaBaja)
        {
            m_Indbaja = true;
            if (this.m_UltimoMovimiento == null) {
                this.m_UltimoMovimiento = new Dominio.Apsogui.GestionAlumnos.Agregados.MovimientoAlumno(MovimientoAlumno.TipoMovimiento.Baja, FechaBaja);
            } else
            {
                m_UltimoMovimiento.setMovimiento(MovimientoAlumno.TipoMovimiento.Baja, FechaBaja);
            }            
        }

        void setActivo(DateTime FechaAlta)
        {
            m_Indbaja = false;
            if (this.m_UltimoMovimiento == null)
            {
                this.m_UltimoMovimiento = new Dominio.Apsogui.GestionAlumnos.Agregados.MovimientoAlumno(MovimientoAlumno.TipoMovimiento.Alta, FechaAlta);
            }
            else
            {
                m_UltimoMovimiento.setMovimiento(MovimientoAlumno.TipoMovimiento.Alta, FechaAlta);
            }            
        }

        void setBaja()
        {
            setBaja(DateTime.Now);
        }

        void setActivo()
        {
            setActivo(DateTime.Now);
        }

        public List<Dominio.Apsogui.GestionAlumnos.Agregados.MovimientoAlumno> getAltasBajas()
        {
            return this.m_AltasBajas;
        }

        #endregion


        public enum eSituacionAlumno
        {
            Baja, Alta        
        }
    }
}
