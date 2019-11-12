using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace TPC_Corrionero
{
    public partial class AltaMateria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarreraNegocio carreraNegocio = new CarreraNegocio();
            dropDownCarrera.DataSource = carreraNegocio.listar();
            dropDownCarrera.DataBind();
        }
    }
}