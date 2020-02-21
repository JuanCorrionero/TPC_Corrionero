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
    public partial class AltaAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

            Page.Validate();
            if(!Page.IsValid)
                 return;

            Alumnos alumno = new Alumnos();
            alumno.Nombre = txtNombre.Text;
            alumno.Apellido = txtApellido.Text;
            alumno.Dni = Convert.ToInt32(txtDni.Text);
            alumno.Mail = txtMail.Text;
            alumno.Telefono = Convert.ToInt32(txtTelefono.Text);
            alumno.Direccion = txtDireccion.Text;
            alumno.Legajo = Convert.ToInt64(txtLegajo.Text);
            AlumnosNegocio negocioAlumno = new AlumnosNegocio();
            if (negocioAlumno.AltaAlumno(alumno)== true)
            {
                Session.Add("Exito", "Alumno cargado con exito!");
                Response.Redirect("PaginaExito.aspx");
            }
            else
            {
                Session.Add("Error", "Hubo un error al ingresar el usuario.");
                Response.Redirect("PaginaError.aspx");
            }
            
            

        }
    }
}