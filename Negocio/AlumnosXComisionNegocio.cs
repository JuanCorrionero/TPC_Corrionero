using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;

namespace Negocio
{
    public class AlumnosXComisionNegocio
    {

        public bool Alta(long IdAlumno, long IdComision)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("Insert into AlumnosPorComision values (@IdAlumno, @IdComision, 1)");
                datos.agregarParametro("@IdAlumno", IdAlumno);
                datos.agregarParametro("@IdComision", IdComision);
                datos.ejecutarAccion();
                return true;
            }
            catch (Exception ex)
            {
                
throw ex;
                //return false;
            }

            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Alumnos> listar(long IdComision)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                List<Alumnos> oAlu = new List<Alumnos>();
                datos.setearQuery("Select A.Id, AC.Id, A.Dni, A.Legajo, A.Apellido, Nombre from Alumnos as A inner join AlumnosPorComision as AC on AC.IdComision = @IdComision where A.Id = AC.IdAlumno and AC.Estado = 1");
                datos.agregarParametro("@IdComision", IdComision);
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    Alumnos Alu = new Alumnos();
                    Alu.Id = datos.lector.GetInt64(0);
                    Alu.IdComision = datos.lector.GetInt64(1);
                    Alu.Dni = datos.lector.GetInt32(2);
                    Alu.Legajo = datos.lector.GetInt64(3);
                    Alu.Apellido = datos.lector.GetString(4);
                    Alu.Nombre = datos.lector.GetString(5);

                    oAlu.Add(Alu);
                    
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

        public List<Alumnos> listarBaja(long IdComision)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                List<Alumnos> oAlu = new List<Alumnos>();
                datos.setearQuery("Select A.Id, AC.Id, A.Dni, A.Legajo, A.Apellido, Nombre from Alumnos as A inner join AlumnosPorComision as AC on AC.IdComision = @IdComision where A.Id = AC.IdAlumno and AC.Estado = 0");
                datos.agregarParametro("@IdComision", IdComision);
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    Alumnos Alu = new Alumnos();
                    Alu.Id = datos.lector.GetInt64(0);
                    Alu.IdComision = datos.lector.GetInt64(1);
                    Alu.Dni = datos.lector.GetInt32(2);
                    Alu.Legajo = datos.lector.GetInt64(3);
                    Alu.Apellido = datos.lector.GetString(4);
                    Alu.Nombre = datos.lector.GetString(5);

                    oAlu.Add(Alu);

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


        public bool BajaAlumno (long Id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

            datos.setearQuery("update AlumnosPorComision set Estado = 0 where Id = @Id");
            datos.agregarParametro("@Id", Id);
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

        public bool ReIngresarAlumno(long Id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearQuery("update AlumnosPorComision set Estado = 1 where Id = @Id");
                datos.agregarParametro("@Id", Id);
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
