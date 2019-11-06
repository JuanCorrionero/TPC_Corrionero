using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Comision
    {
        public Materia Materia { get; set; }
        public string Turno { get; set; }
        public int Cuatrimestre { get; set; }
        public int Año { get; set; }
        public Carrera Carrera { get; set; }
        public Instancia Instancia { get; set; }
        public Alumnos Alumno { get; set; }
        public Docentes Docente { get; set; }

    }
}
