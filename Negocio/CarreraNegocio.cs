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


    }
}
