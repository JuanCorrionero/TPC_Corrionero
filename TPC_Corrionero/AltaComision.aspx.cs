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
    public partial class AltaComision : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                 Materia materia = new Materia();
                Turnos turno = new Turnos();
                MateriaNegocio NegMateria = new MateriaNegocio();
                TurnosNegocio turnoNegocio = new TurnosNegocio();

                dwMateria.DataSource = NegMateria.listar();
                dwMateria.DataValueField = "Id";
                dwMateria.DataTextField = "Nombre";
                dwMateria.DataBind();

                dwTurnos.DataSource = turnoNegocio.listar();
                dwTurnos.DataValueField = "Id";
                dwTurnos.DataTextField = "Nombre";
                dwTurnos.DataBind();

            }
        }
    }
}