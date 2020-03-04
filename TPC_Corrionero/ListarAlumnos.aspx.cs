using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace TPC_Corrionero
{
    public partial class ListarAlumnos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Docentes docenteLogeado = new Docentes();
            docenteLogeado = (Docentes)Session["docenteLogeado"];

            if (docenteLogeado == null)
            {
                Response.Redirect("Login.aspx");
            }

            if (!IsPostBack)
            {
                AlumnosNegocio negocio = new AlumnosNegocio();
                dgvAlumnos.DataSource = negocio.ListarAlumnos();
                dgvAlumnos.DataBind();
            }

        }

        protected void dgvAlumnos_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }
    }
}