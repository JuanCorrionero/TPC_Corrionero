﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Instancia
    {
        public string Nombre { get; set; }
        public string Observacion { get; set; }

        public override string ToString()
        {
            return Observacion;
        }
    }
}
