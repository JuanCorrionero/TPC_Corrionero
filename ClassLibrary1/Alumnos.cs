using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Alumnos : Usuarios
    {
        public Alumnos()
        {

        }

        public long Legajo { get; set; }
        public Comision Comision { get; set; }

    }
}
