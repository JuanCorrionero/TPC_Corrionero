using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;



namespace Negocio
{
    public class AlumnosNegocio
    {
        public bool AltaAlumno(Alumnos alumnoWeb)
        {
            //Instancio primero acceso a datos.
            AccesoDatos accesoDatos = new AccesoDatos();
            
            try
            {
                accesoDatos.setearQuery("insert into Alumnos values(@Nombre, @Apellido, @Dni, @Email, @Telefono, @Direccion, @Legajo)");
                accesoDatos.agregarParametro("@Nombre", alumnoWeb.Nombre);
                accesoDatos.agregarParametro("Apellido", alumnoWeb.Apellido);
                accesoDatos.agregarParametro("@Dni", alumnoWeb.Dni);
                accesoDatos.agregarParametro("@Email", alumnoWeb.Mail);
                accesoDatos.agregarParametro("@Telefono", alumnoWeb.Telefono);
                accesoDatos.agregarParametro("@Direccion", alumnoWeb.Direccion);
                accesoDatos.agregarParametro("@Legajo", alumnoWeb.Legajo);

                accesoDatos.ejecutarAccion();
                return true;

            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                accesoDatos.cerrarConexion();
            }
        }
    }
}
