using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MateriaNegocio
    {
        public void AltaMateria (Materia materiaWeb)
        {

            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setearQuery("Insert into Materias values (@Nombre,@IdCarrera)");
                datos.agregarParametro("@Nombre", materiaWeb.Nombre);
                datos.agregarParametro("@IdCarrera", materiaWeb.Carrera.Id);


            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {

            }
        }

    }
}
