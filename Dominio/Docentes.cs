﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Docentes 
    {
        public Docentes()
        {
        }
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public string Mail { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public long Legajo { get; set; }
        public Comision Comision { get; set; }
        public string Password { get; set; }
        public bool admin { get; set; }
    }
}
