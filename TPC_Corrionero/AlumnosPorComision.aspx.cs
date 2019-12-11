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
                //NombreComision = negocio.NombreComision(IdComision);
                //lblNombreComision.Text = NombreComision;

            }
        }



    }
}