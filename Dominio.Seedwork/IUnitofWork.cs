﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Seedwork
{
    interface IUnitofWork
    {
        void Guardar();
        void Eliminar();        
    }
}
