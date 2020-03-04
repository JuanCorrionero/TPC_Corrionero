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

        public List<Alumnos> Listar()
        {

                AccesoDatos datos = new AccesoDatos();

            try
            {
                List<Alumnos> oAlu = new List<Alumnos>();
                datos.setearQuery("Select Id, Dni, Apellido, Nombre, Legajo from Alumnos");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                Alumnos alu = new Alumnos();
                    alu.Id = datos.lector.GetInt64(0);
                    alu.Dni = datos.lector.GetInt32(1);
                    alu.Apellido = datos.lector.GetString(2);
                    alu.Nombre = datos.lector.GetString(3);
                    alu.Legajo = datos.lector.GetInt64(4);

                    oAlu.Add(alu);
                }

                return oAlu;


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

        public List<Alumnos> ListarAlumnos()
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {
                List<Alumnos> oAlu = new List<Alumnos>();
                datos.setearQuery("Select Id, Apellido, Nombre, Email from Alumnos");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    Alumnos alu = new Alumnos();
                    alu.Id = datos.lector.GetInt64(0);
                    alu.Apellido = datos.lector.GetString(1);
                    alu.Nombre = datos.lector.GetString(2);
                    alu.Mail = datos.lector.GetString(3);

                    oAlu.Add(alu);
                }

                return oAlu;


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

        string Nombre;
        public string ApellidoAlumno(long Id)
        {
                Alumnos oAlumno = new Alumnos();
                AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("Select Apellido from Alumnos where @Id = Id");
                datos.agregarParametro("@Id", Id);
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                     Nombre = datos.lector.GetString(0);
                }
                return Nombre;

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

        string Email;
        public string mailAlumno(long Id)
        {
            Alumnos oAlumno = new Alumnos();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("Select Email from Alumnos where @Id = Id");
                datos.agregarParametro("@Id", Id);
                datos.ejecutarLector();
                if (datos.lector.Read())
                {
                    Email = datos.lector.GetString(0);
                }

                return Email;

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
