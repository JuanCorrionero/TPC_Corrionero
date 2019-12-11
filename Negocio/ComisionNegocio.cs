using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
     public class ComisionNegocio
    {

        public bool altaComision(Comision comisionWEB, long idTurno, long idMateria)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
            datos.setearQuery("Insert into Comisiones values(@Nombre, @IdMateria, @IdTurnos, @Cuatrimestre)");
            datos.agregarParametro("@Nombre", comisionWEB.Nombre);
            datos.agregarParametro("@IdMateria", idMateria);
            datos.agregarParametro("@IdTurnos", idTurno);
            datos.agregarParametro("@Cuatrimestre", comisionWEB.Cuatrimestre);
            datos.ejecutarAccion();


                return true;
            }
            catch (Exception ex)
            {

                throw ex;
                return false;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Comision> listar()
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                List<Comision> aux = new List<Comision>();
                datos.setearQuery("Select C.Id, C.Nombre, M.Nombre, T.Nombre, Cuatrimestre from Comisiones as C inner join Materias as M on C.IdMateria = M.Id inner join Turnos as T on C.IdTurnos = T.Id");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {

                    Comision comision = new Comision();
                    comision.Id = datos.lector.GetInt64(0);
                    comision.Nombre = datos.lector.GetString(1);
                    comision.Materia = new Materia();
                    comision.Materia.Nombre = datos.lector.GetString(2);
                    comision.Turno = new Turnos();
                    comision.Turno.Nombre = datos.lector.GetString(3);
                    comision.Cuatrimestre = datos.lector.GetInt32(4);

                    aux.Add(comision);
                    
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

            string nombre;
        public string NombreComision(long IdComision)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("Select Nombre from Comisiones where Id = @Id");
                datos.agregarParametro("@Id", IdComision);
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    nombre = datos.lector.GetString(0);

                }
                    return nombre;
                
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
