using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace TPC_Corrionero
{
    public partial class AltaMateria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Docentes docenteLogeado = new Docentes();
            docenteLogeado = (Docentes)Session["docenteLogeado"];

            if (docenteLogeado == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (docenteLogeado.admin == false)
            {
                Response.Redirect("PagPrincipal.aspx");
            }


            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

            CarreraNegocio carreraNegocio = new CarreraNegocio();

            if (!IsPostBack)
            {
                dropDownCarrera.DataSource = carreraNegocio.listar();
                dropDownCarrera.DataTextField = "Nombre";
                dropDownCarrera.DataValueField = "Id";
                dropDownCarrera.DataBind();

            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            //Antes de agregar al docente, verifica las validaciones
            Page.Validate();
            if (!Page.IsValid)
                return;

            Materia materia = new Materia();
            Carrera carrera = new Carrera();
            MateriaNegocio negocio = new MateriaNegocio();
            materia.Nombre = txtMateria.Text;
            // TODO: Revisar como traer la informacion del dropdownlist para traer el objeto o al menos la info.
            // Solucionado 15/11 - Tiene que haber otra forma menos fea de hacer.
            long idCarrera = Convert.ToInt64( dropDownCarrera.SelectedItem.Value);
            if (negocio.AltaMateria(materia, idCarrera))
            {
                Session.Add("Exito", "Materia ingresada con éxito!");
                Response.Redirect("PaginaExito.aspx");
            }
            else
            {
                Session.Add("Error", "Hubo un error ingresando la materia.");
                Response.Redirect("PaginaError.aspx");
            }
            //materia.Carrera.Id = algo;
            //materia.Carrera.Nombre = dropDownCarrera.SelectedItem.Text;
        }
    }
}