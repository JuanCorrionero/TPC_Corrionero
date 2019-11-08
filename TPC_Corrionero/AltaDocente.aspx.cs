using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPC_Corrionero
{
    public partial class AltaDocente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       // TODO: Hacer la pagina principal con navegacion para crear un alumno y un docente
       // TODO: Luego poder asignarle una comision para poder crearle una instancia y poder agregarle cmentarios.

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Docentes docente = new Docentes();
            docente.Nombre = txtNombre.Text;
            docente.Apellido = txtApellido.Text;
            docente.Dni = Convert.ToInt32(txtDni.Text);
            docente.Mail = txtMail.Text;
            docente.Telefono = Convert.ToInt32(txtTelefono.Text);
            docente.Direccion = txtDireccion.Text;
            docente.Legajo = Convert.ToInt64(txtLegajo.Text);
            DocentesNegocio negocioDocente = new DocentesNegocio();
            if (negocioDocente.CrearCliente(docente) == true)
            {
                Response.Write("<script>alert('Alumno creado con éxito!')</script>");
            }
            else
            {
                Session.Add("Error", "Hubo un error al ingresar el usuario.");
                Response.Redirect("PaginaError.aspx");
            }
        }
    }
}