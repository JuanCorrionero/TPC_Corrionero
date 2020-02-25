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
                barraNav.Visible = false;
            }

            if(docenteLogeado != null)
            {
                if(docenteLogeado.admin == false)
                {
                    navAltaAlumno.Visible = false;
                    navAltaCarrera.Visible = false;
                    navAltaDocente.Visible = false;
                    navAltaMateria.Visible = false;
                }
            }

        }
    }
}