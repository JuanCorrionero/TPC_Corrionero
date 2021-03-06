﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPC_Corrionero
{
    public partial class AgregarAlumnoComision : System.Web.UI.Page
    {
        public string NombreComision;

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
                ComisionNegocio negocio = new ComisionNegocio();
                long IdComision = Convert.ToInt64(Session["IdComision"]);
                NombreComision = negocio.NombreComision(IdComision);
                lblComision.Text = NombreComision;
  AlumnosNegocio AluNegocio = new AlumnosNegocio();
            dgvListaAlumnos.DataSource = AluNegocio.Listar();
            dgvListaAlumnos.DataBind();

            }

          
        }

        protected void dgvListaAlumnos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Agregar")
            {
                int index = Convert.ToInt32(e.CommandArgument);

                //Reference the GridView Row.
                GridViewRow row = dgvListaAlumnos.Rows[index];

                long Id = Convert.ToInt64(row.Cells[0].Text);
                AlumnosXComisionNegocio AluCoNegocio = new AlumnosXComisionNegocio();
                if(AluCoNegocio.Alta(Id, Convert.ToInt64(Session["IdComision"])))
                {
                
                Response.Redirect("AlumnosPorComision.aspx");

                }

                else
                {
                    string error = "Hubo un error agregando el alumno a la comision";
                    Session.Add("Error", error);
                    Response.Redirect("PaginaError.aspx");
                }

            }
        }

        protected void BotonVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("AlumnosPorComision.aspx");
        }
    }
}