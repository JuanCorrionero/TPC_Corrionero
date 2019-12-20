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
    public partial class InstanciaPorComision : System.Web.UI.Page
    {
            public string NombreComision;
            public string NombreAlumno;
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                ComisionNegocio negocio = new ComisionNegocio();
                long IdComision = Convert.ToInt64(Session["IdComision"]);
                NombreComision = negocio.NombreComision(IdComision);
                lblComision.Text = NombreComision;

                AlumnosNegocio nego = new AlumnosNegocio();
                NombreAlumno = nego.ApellidoAlumno(Convert.ToInt64(Session["IdAlumno"]));
                lblAlumno.Text = NombreAlumno;

                long IdAlumno = Convert.ToInt64(Session["IdAlumno"]);
                    InstanciaNegocio negocioInsta = new InstanciaNegocio();
                    dgvListaInstancias.DataSource = negocioInsta.listar(IdComision, IdAlumno);
                    dgvListaInstancias.DataBind();
                
            }
            
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

            Response.Redirect("AgregarInstancia.aspx");
        }

        protected void dgvListaInstancias_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Agregar")
            {
                int index = Convert.ToInt32(e.CommandArgument);

                //Reference the GridView Row.
                GridViewRow row = dgvListaInstancias.Rows[index];

                long Id = Convert.ToInt64(row.Cells[0].Text);

                Session.Add("IdInstancia", Id);
                Response.Redirect("Observaciones.aspx");

            }
        }
    }
}