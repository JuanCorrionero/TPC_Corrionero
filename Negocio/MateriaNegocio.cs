using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MateriaNegocio
    {

        public bool AltaMateria (Materia materiaWeb, long idCarrera)
        {

            AccesoDatos datos = new AccesoDatos();


            try
            {
                datos.setearQuery("Insert into Materias values (@Nombre,@IdCarrera)");
                datos.agregarParametro("@Nombre", materiaWeb.Nombre);
                datos.agregarParametro("@IdCarrera", idCarrera);
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

        public List<Materia> listar()
        {
            List<Materia> lista = new List<Materia>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("Select Id, Nombre from Materias");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    Materia materia = new Materia();
                    materia.Id = datos.lector.GetInt64(0);
                    materia.Nombre = datos.lector.GetString(1);
                    lista.Add(materia);
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
