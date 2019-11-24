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
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                Comision comision = new Comision();
                ComisionNegocio negocio = new ComisionNegocio();
                
                

            }
        }



    }
}