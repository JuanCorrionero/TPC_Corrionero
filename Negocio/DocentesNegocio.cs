using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class DocentesNegocio
    {
        public bool altaDocente(Docentes docenteWeb)
        {
            //Instancio primero acceso a datos.
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearQuery("insert into Alumnos values(@Nombre, @Apellido, @Dni, @Email, @Telefono, @Direccion, @Legajo)");
                accesoDatos.agregarParametro("@Nombre", docenteWeb.Nombre);
                accesoDatos.agregarParametro("Apellido", docenteWeb.Apellido);
                accesoDatos.agregarParametro("@Dni", docenteWeb.Dni);
                accesoDatos.agregarParametro("@Email", docenteWeb.Mail);
                accesoDatos.agregarParametro("@Telefono", docenteWeb.Telefono);
                accesoDatos.agregarParametro("@Direccion", docenteWeb.Direccion);
                accesoDatos.agregarParametro("@Legajo", docenteWeb.Legajo);

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
