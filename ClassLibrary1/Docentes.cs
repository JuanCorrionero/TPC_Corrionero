using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Docentes : Usuarios
    {
        public Docentes()
        {
        }

        public long Legajo { get; set; }
        public int MyProperty { get; set; }
        public Comision Comision { get; set; }
    }
}
