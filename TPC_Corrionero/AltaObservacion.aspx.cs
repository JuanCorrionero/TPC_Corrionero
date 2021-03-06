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
    public partial class AltaObservacion : System.Web.UI.Page
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

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            //Antes de agregar al docente, verifica las validaciones
            Page.Validate();
            if (!Page.IsValid)
                return;
            ObservacionesInstancia obs = new ObservacionesInstancia();
            obs.Descripcion = txtDescripcion.Text;
            obs.IdAlumno = Convert.ToInt64(Session["IdAlumno"]);
            obs.IdComision = Convert.ToInt64(Session["IdComision"]);
            obs.IdInstancias = Convert.ToInt64(Session["IdInstancia"]);
            ObservacionesNegocio negocio = new ObservacionesNegocio();
            if (negocio.AltaObservacion(obs))
            {
                Session.Add("Exito", "La observacion ha sido añadida con exito!");
                Response.Redirect("PaginaExito.aspx");
            }

            else
            {
                Session.Add("Error", "Hubo un error al añadir una observacion a la instancia evaluativa");
                Response.Redirect("PaginaError.aspx");
            }



        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Observaciones.aspx");
        }
    }
}