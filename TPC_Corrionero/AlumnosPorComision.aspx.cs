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
    public partial class AlumnosPorComision : System.Web.UI.Page
    {
               public string NombreComision;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                ComisionNegocio negocio = new ComisionNegocio();
                long IdComision = Convert.ToInt64( Session["IdComision"]);
                NombreComision = negocio.NombreComision(IdComision);
                lblNombreComision.Text = NombreComision;

                AlumnosXComisionNegocio nego = new AlumnosXComisionNegocio();

                dgvAlumnosPorComision.DataSource = nego.listar(IdComision);
                dgvAlumnosPorComision.DataBind();

            }


        }

        protected void dgvAlumnosPorComision_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "VerInstancia")
            {
                int index = Convert.ToInt32(e.CommandArgument);

                //Reference the GridView Row.
                GridViewRow row = dgvAlumnosPorComision.Rows[index];

                long Id = Convert.ToInt64(row.Cells[0].Text);

                Session.Add("IdAlumno", Id);
                Response.Redirect("InstanciaPorComision.aspx");

            }
        }
    }
}