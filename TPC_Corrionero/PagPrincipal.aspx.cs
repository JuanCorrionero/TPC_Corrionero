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
    public partial class PagPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Docentes docenteLogeado = new Docentes();
            docenteLogeado = (Docentes)Session["docenteLogeado"];

            if (docenteLogeado == null )
            {
                Response.Redirect("Login.aspx");
            }
            
            if (docenteLogeado.admin == false)
            {
                cardAlumno.Visible = false;
                cardDocente.Visible = false;
                cardMateria.Visible = false;
                
            }

            //object usuarioLogueado = Session["usuarioLogueado"];
            //if (usuarioLogueado != null)
            //{
            //    if (!usuarioLogueado.Admin)
            //    {

            //    }
            //}


            //// cuando te loguees si esta todo ok vas a hacer
            //Session.Add("usuarioLogueado", new object());

        }
    }
}