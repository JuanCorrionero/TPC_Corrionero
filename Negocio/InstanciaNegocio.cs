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

        public List<Instancia> listar(long IdComision, long IdAlumno)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                List<Instancia> oInsta = new List<Instancia>();
                datos.setearQuery("Select Id, Nombre from Instancias where IdComision = @IdComision and IdAlumno = @IdAlumno");
                datos.agregarParametro("@IdComision", IdComision);
                datos.agregarParametro("@IdAlumno", IdAlumno);
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                Instancia aux = new Instancia();
                    aux.Id = datos.lector.GetInt64(0);
                    aux.Nombre = datos.lector.GetString(1);
                    oInsta.Add(aux);

                }

                return oInsta;

            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                datos.cerrarConexion();
            }
        }

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
