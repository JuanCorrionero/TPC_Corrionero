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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            DocentesNegocio negocio = new DocentesNegocio();
            long legajo = Convert.ToInt64( txtLegajo.Text);
            string pass = txtPass.Text;
            if (negocio.docenteLogin(legajo, pass))
            {
                Response.Redirect("PagPrincipal.aspx");
            }
            else
            {
                Session.Add("Error", "Contraseña o Legajo incorrecto, reintente o regístrese.");
                Response.Redirect("PaginaError.aspx");
            }

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AltaDocente.aspx");
        }
    }
}