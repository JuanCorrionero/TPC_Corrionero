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
    public partial class ListarComision : System.Web.UI.Page
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
            ComisionNegocio negocio = new ComisionNegocio();
            dgvListaComision.DataSource = negocio.listar();
            dgvListaComision.DataBind();

            }
        }

        protected void dgvListaComision_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "VerAlumnos")
            {
                int index = Convert.ToInt32(e.CommandArgument);

                //Reference the GridView Row.
                GridViewRow row = dgvListaComision.Rows[index];

                long Id = Convert.ToInt64( row.Cells[0].Text);

                Session.Add("IdComision", Id);
                Response.Redirect("AlumnosPorComision.aspx");

            }

            if (e.CommandName == "AgregarAlumno")
            {
                int index = Convert.ToInt32(e.CommandArgument);

                //Reference the GridView Row.
                GridViewRow row = dgvListaComision.Rows[index];

                long Id = Convert.ToInt64(row.Cells[0].Text);

                Session.Add("IdComision", Id);
                Response.Redirect("AgregarAlumnoComision.aspx");

            }
        }
    }
}