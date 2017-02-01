using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Apsogui.GestionAlumnos { 
    class MovimientoAlumno
    {
        private string m_IdAlumno="";        
        private int m_TipoMovimiento = 0;
        private DateTime? m_FechaMovimiento = null;

        public MovimientoAlumno(string idAlumno, TipoMovimiento tipoMovimiento, DateTime fechaMovimiento)
        {
            m_IdAlumno = idAlumno;
            m_TipoMovimiento = (int)tipoMovimiento;
            m_FechaMovimiento = fechaMovimiento;
        }

        public enum TipoMovimiento {Baja=1,Alta=2}


    }


}
