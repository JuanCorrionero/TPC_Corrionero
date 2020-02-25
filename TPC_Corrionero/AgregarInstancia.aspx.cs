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
    public partial class AgregarInstancia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Docentes docenteLogeado = new Docentes();
            docenteLogeado = (Docentes)Session["docenteLogeado"];

            if (docenteLogeado == null)
            {
                Response.Redirect("Login.aspx");
            }


            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;


        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            //Antes de agregar al docente, verifica las validaciones
            Page.Validate();
            if (!Page.IsValid)
                return;

            Instancia oInstancia = new Instancia();
            oInstancia.Nombre = txtInstancia.Text;
            oInstancia.IdAlumno = Convert.ToInt64(Session["IdAlumno"]);
            oInstancia.IdComision = Convert.ToInt64(Session["IdComision"]);

            InstanciaNegocio negocio = new InstanciaNegocio();
            if (negocio.AltaInstancia(oInstancia))
            {
                Session.Add("Exito", "La instancia ha sido agregada con exito!");
                Response.Redirect("PaginaExito.aspx");
            }
            else
            {
                Session.Add("Error", "Hubo un error al agregar la instancia");
                Response.Redirect("PaginaError.aspx");
            }

        }
    }
}