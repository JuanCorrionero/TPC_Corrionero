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
        public bool AltaMateria (Materia materiaWeb, long idCarrera)
        {

            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setearQuery("Insert into Materias values (@Nombre,@IdCarrera)");
                datos.agregarParametro("@Nombre", materiaWeb.Nombre);
                datos.agregarParametro("@IdCarrera", idCarrera);
                datos.ejecutarAccion();

                return true;
            }
            catch (Exception ex)
            {

                throw ex;
                return false;
            }

            finally
            {
                datos.cerrarConexion();
            }
        }

    }
}
