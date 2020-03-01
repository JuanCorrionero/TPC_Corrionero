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
    public partial class EditarObs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Docentes docenteLogeado = new Docentes();
            docenteLogeado = (Docentes)Session["docenteLogeado"];

            if (docenteLogeado == null)
            {
                Response.Redirect("Login.aspx");
            }

            long Id = (long)Session["IdObs"];
            txtDescripcion.Attributes.Add("placeholder", (string)Session["Obs"]);

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            ObservacionesInstancia obs = new ObservacionesInstancia();
            ObservacionesNegocio negocio = new ObservacionesNegocio();

            obs.Id = (long)Session["IdObs"];
            obs.Descripcion = txtDescripcion.Text;

            if (negocio.Editar(obs))
            {
                Response.Redirect("Observaciones.aspx");
            }
            else
            {
                Response.Redirect("PaginaError.aspx");
            }
            
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Observaciones.aspx");
        }
    }
}