using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class TurnosNegocio
    {

        public List<Turnos> listar()
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                List<Turnos> lista = new List<Turnos>();
                datos.setearQuery("Select Id, Nombre from Turnos");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    Turnos turnos = new Turnos();
                    turnos.Id = datos.lector.GetInt64(0);
                    turnos.Nombre = datos.lector.GetString(1);

                    lista.Add(turnos);

                }

                return lista;


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
