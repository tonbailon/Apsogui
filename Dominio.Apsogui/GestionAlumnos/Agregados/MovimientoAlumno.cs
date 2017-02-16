using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Apsogui.GestionAlumnos.Agregados { 
    public class MovimientoAlumno
    {
        //private string m_IdAlumno="";        
        private int m_TipoMovimiento;
        private DateTime? m_FechaMovimiento;

        public MovimientoAlumno(TipoMovimiento tipoMovimiento, DateTime fechaMovimiento)
        {
            //m_IdAlumno = idAlumno;
            this.m_TipoMovimiento = (int)tipoMovimiento;
            this.m_FechaMovimiento = fechaMovimiento;
        }

        public void setMovimiento(TipoMovimiento tipoMovimiento, DateTime fechaMovimiento)
        {
            this.m_TipoMovimiento = (int)tipoMovimiento;
            this.m_FechaMovimiento = fechaMovimiento;
        }
        public enum TipoMovimiento {Baja=1,Alta=2}


    }


}
