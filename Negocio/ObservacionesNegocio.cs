using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ObservacionesNegocio
    {

        public bool AltaObservacion(ObservacionesInstancia obsWeb)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("Insert into Observaciones values(@Descripcion, @IdComision, @IdAlumno, @IdInstancias)");
                datos.agregarParametro("@Descripcion", obsWeb.Descripcion);
                datos.agregarParametro("@IdComision", obsWeb.IdComision);
                datos.agregarParametro("@IdAlumno", obsWeb.IdAlumno);
                datos.agregarParametro("@IdInstancias", obsWeb.IdInstancias);
                datos.ejecutarAccion();

                return true;


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

        public List<ObservacionesInstancia> Listar(long IdComision, long IdAlumno, long IdInstancia)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                List<ObservacionesInstancia> aux = new List<ObservacionesInstancia>();

                datos.setearQuery("Select Id, Descripcion from Observaciones where IdComision = @IdComision and IdAlumno = @IdAlumno and IdInstancias = @IdInstancia");
                datos.agregarParametro("@IdComision", IdComision);
                datos.agregarParametro("@IdAlumno", IdAlumno);
                datos.agregarParametro("@IdInstancia", IdInstancia);
                datos.ejecutarLector();

                while (datos.lector.Read())
                {
                    ObservacionesInstancia obs = new ObservacionesInstancia();
                    obs.Id = datos.lector.GetInt64(0);
                    obs.Descripcion = datos.lector.GetString(1);

                    aux.Add(obs);
                }

                return aux;

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

    }
}
