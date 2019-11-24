using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Comision
    {
        public string Nombre { get; set; }
        public Materia Materia { get; set; }
        public Turnos Turno { get; set; }
        public int Cuatrimestre { get; set; }
       
    }
}
