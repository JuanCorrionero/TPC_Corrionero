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
            Docentes docenteLogeado = new Docentes();
            docenteLogeado = (Docentes)Session["docenteLogeado"];

            if (docenteLogeado == null)
            {
                chkLogin.Visible = false;
            }


            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        }


        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            //Antes de agregar al docente, verifica las validaciones
            Page.Validate();
            if (!Page.IsValid)
                return;

            Docentes docente = new Docentes();
            docente.Nombre = txtNombre.Text;
            docente.Apellido = txtApellido.Text;
            docente.Dni = Convert.ToInt32(txtDni.Text);
            docente.Mail = txtMail.Text;
            docente.Password = txtPass.Text;
            docente.Telefono = Convert.ToInt32(txtTelefono.Text);
            docente.Direccion = txtDireccion.Text;
            docente.Legajo = Convert.ToInt64(txtLegajo.Text);

            if(chkLogin.Checked == true)
            {
                docente.admin = true;
            }
            else
            {
                docente.admin = false;
            }

            DocentesNegocio negocioDocente = new DocentesNegocio();
            if (negocioDocente.altaDocente(docente) == true)
            {
                Session.Add("Exito", "Docente agregado con exito!");
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