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

        public Docentes traerDocente(long legajo)
        {
                AccesoDatos datos = new AccesoDatos();
            try
            {


                datos.setearQuery("Select Id, Nombre, Apellido, Dni, Email, Telefono, Direccion, Legajo, admin from Docentes where Legajo = @legajo");
                datos.agregarParametro("@Legajo", legajo);
                datos.ejecutarLector();
                Docentes docente = new Docentes();

                while (datos.lector.Read())
                {
                    docente.Id = datos.lector.GetInt64(0);
                    docente.Nombre = datos.lector.GetString(1);
                    docente.Apellido = datos.lector.GetString(2);
                    docente.Dni = datos.lector.GetInt32(3);
                    docente.Mail = datos.lector.GetString(4);
                    docente.Telefono = datos.lector.GetInt32(5);
                    docente.Direccion = datos.lector.GetString(6);
                    docente.Legajo = datos.lector.GetInt64(7);
                    docente.admin = datos.lector.GetBoolean(8);
                                 
                }

                return docente;

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
