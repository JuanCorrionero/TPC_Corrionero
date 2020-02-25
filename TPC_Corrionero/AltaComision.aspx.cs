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

            Docentes docenteLogeado = new Docentes();
            docenteLogeado = (Docentes)Session["docenteLogeado"];

            if (docenteLogeado == null)
            {
                Response.Redirect("Login.aspx");
            }


            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;


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

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            //Antes de agregar al docente, verifica las validaciones
            Page.Validate();
            if (!Page.IsValid)
                return;

            try
            {
            ComisionNegocio negocio = new ComisionNegocio();
            Comision comision = new Comision();
                // comision.Turno = new Turnos();
            Materia materia = new Materia();
            Turnos turno = new Turnos();
                comision.Nombre = txtNombre.Text;
                comision.Cuatrimestre = Convert.ToInt16(txtCuatrimestre.Text);
                long idTurno = Convert.ToInt64(dwTurnos.SelectedItem.Value);
                long idMateria = Convert.ToInt64(dwMateria.SelectedItem.Value);
                if(negocio.altaComision(comision, idTurno, idMateria))
                {
                    Session.Add("Exito", "La comision ha sido agregada con exito!");
                    Response.Redirect("PaginaExito.aspx");
                }
                else
                {
                    Session.Add("Error", "Hubo un error dando de alta la comision");
                    Response.Redirect("PaginaError.aspx");
                }
                //comision.Turno.Id = algo; 
                //comision.Materia.Id = algo1;
            
                



            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}