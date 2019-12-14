using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;

namespace Negocio
{
    public class AlumnosXComisionNegocio
    {

        public bool Alta(long IdAlumno, long IdComision)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("Insert into AlumnosPorComision values (@IdAlumno, @IdComision)");
                datos.agregarParametro("@IdAlumno", IdAlumno);
                datos.agregarParametro("@IdComision", IdComision);
                datos.ejecutarAccion();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }

            finally
            {
                datos.cerrarConexion();
            }
        }

    }
}
