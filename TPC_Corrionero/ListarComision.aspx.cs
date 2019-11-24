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
            if (!IsPostBack)
            {
            ComisionNegocio negocio = new ComisionNegocio();
            dgvListaComision.DataSource = negocio.listar();

            dgvListaComision.DataBind();

            }
        }

        protected void dgvListaComision_RowEditing(object sender, GridViewEditEventArgs e)
        {
            
            Session.Add("IdComision", e.NewEditIndex);
            var algo =  Session["IdComision"];

        }
    }
}