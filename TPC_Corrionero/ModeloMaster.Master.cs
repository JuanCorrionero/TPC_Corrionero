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
    public partial class ModeloMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Docentes docenteLogeado = new Docentes();
            docenteLogeado = (Docentes)Session["docenteLogeado"];

            if(docenteLogeado == null)
            {
                cardDocente.Visible = false;
                barraNav.Visible = false;
            }

            if(docenteLogeado != null)
            {
                lblDocente.Text = "Docente: " + docenteLogeado.Apellido + ", " + docenteLogeado.Nombre;
                
                if(docenteLogeado.admin == false)
                {
                    navAltaAlumno.Visible = false;
                    navAltaCarrera.Visible = false;
                    navAltaDocente.Visible = false;
                    navAltaMateria.Visible = false;
                }
            }

        }

        protected void btnSalirUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}