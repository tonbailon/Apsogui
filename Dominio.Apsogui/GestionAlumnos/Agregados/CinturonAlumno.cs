﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Apsogui.GestionAlumnos.Agregados
{
    class CinturonAlumno : Cinturon
    {
        public CinturonAlumno() {
        }

        public Boolean entregadoEnGimnasio { get; set; }

        public DateTime FechaEntrega { get; set; }



    }
}
