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
    public partial class Observaciones : System.Web.UI.Page
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

                long IdComision = Convert.ToInt64(Session["IdComision"]);
                long IdAlumno = Convert.ToInt64(Session["IdAlumno"]);
                long IdInstancia = Convert.ToInt64(Session["IdInstancia"]);

                ObservacionesNegocio negocio = new ObservacionesNegocio();
                dgvListaObservaciones.DataSource = negocio.Listar(IdComision, IdAlumno, IdInstancia);
                dgvListaObservaciones.DataBind();
            }

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AltaObservacion.aspx");
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("InstanciaPorComision.aspx");
        }
    }
}