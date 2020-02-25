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
    public partial class AltaCarrera : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Docentes docenteLogeado = new Docentes();
            docenteLogeado = (Docentes)Session["docenteLogeado"];

            if (docenteLogeado == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (docenteLogeado.admin == false)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('No tienes permisos de administrador')", true);
                Response.Redirect("PagPrincipal.aspx");
            }


            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            //Antes de agregar al docente, verifica las validaciones
            Page.Validate();
            if (!Page.IsValid)
                return;
            Carrera carrera = new Carrera();
            CarreraNegocio negocio = new CarreraNegocio();

            carrera.Nombre = txtNombre.Text;

            if (negocio.AltaCarrera(carrera))
            {
                Session.Add("Exito", "Carrera agregada con Exito!");
                Response.Redirect("PaginaExito.aspx");
            }
            else
            {
                Session.Add("Error", "Hubo un error cargando la Carrera");
                Response.Redirect("PaginaError.aspx");
            }




        }
    }
}