using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CarreraNegocio
    { 
    

        public bool AltaCarrera(Carrera carreraWeb)
        {
        AccesoDatos datos = new AccesoDatos();
        Carrera carrera = new Carrera();

        try
        {
            datos.setearQuery("Insert into Carrera values(@Nombre)");
            datos.agregarParametro("@Nombre", carreraWeb.Nombre);
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

        public List<Carrera> listar()
        {
            // Instancio carrera, la lista de carrera y los datos
            Carrera aux = new Carrera();
            List<Carrera> lista = new List<Carrera>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                // Seteo la query donde voy a leer en la DB
            datos.setearQuery("Select Id, Nombre from Carrera");
                // ejecuto
            datos.ejecutarLector();
            while(datos.lector.Read())
            {
                aux = new Carrera();
                aux.Id = datos.lector.GetInt64(0);
                aux.Nombre = datos.lector.GetString(1);
                
                lista.Add(aux);
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
