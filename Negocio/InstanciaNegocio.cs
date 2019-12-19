using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class InstanciaNegocio
    {

        public bool AltaInstancia(Instancia instanciaWeb)
        {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("Insert into Instancias values(@Nombre, @IdComision, @IdAlumno )");
                datos.agregarParametro("@Nombre", instanciaWeb.Nombre);
                datos.agregarParametro("@IdComision", instanciaWeb.IdComision);
                datos.agregarParametro("@IdAlumno", instanciaWeb.IdAlumno);
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
