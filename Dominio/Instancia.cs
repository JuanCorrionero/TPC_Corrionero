using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Instancia
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public long IdComision { get; set; }
        public long IdAlumno { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
