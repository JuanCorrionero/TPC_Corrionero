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
                accesoDatos.setearQuery("insert into Docentes values(@Nombre, @Apellido, @Dni, @Email, @Telefono, @Direccion, @Legajo, @Password, @admin)");
                accesoDatos.agregarParametro("@Nombre", docenteWeb.Nombre);
                accesoDatos.agregarParametro("Apellido", docenteWeb.Apellido);
                accesoDatos.agregarParametro("@Dni", docenteWeb.Dni);
                accesoDatos.agregarParametro("@Email", docenteWeb.Mail);
                accesoDatos.agregarParametro("@Telefono", docenteWeb.Telefono);
                accesoDatos.agregarParametro("@Direccion", docenteWeb.Direccion);
                accesoDatos.agregarParametro("@Legajo", docenteWeb.Legajo);
                accesoDatos.agregarParametro("@Password", docenteWeb.Password);
                accesoDatos.agregarParametro("@admin", docenteWeb.admin);

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

        public bool docenteLogin(long legajo, string pass)
        {
                AccesoDatos accesoDatos = new AccesoDatos();
            try
            {

                Docentes docente = new Docentes();
                bool flag = true;
                accesoDatos.setearQuery("Select Legajo, Password from Docentes");
                accesoDatos.ejecutarLector();
                while (accesoDatos.lector.Read() && flag == true)
                {
                    docente.Legajo = accesoDatos.lector.GetInt64(0);
                    docente.Password = accesoDatos.lector.GetString(1);

                    if(docente.Legajo == legajo && docente.Password == pass)
                    {
                        flag = false;
                    }
                }
                if (flag== false)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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
