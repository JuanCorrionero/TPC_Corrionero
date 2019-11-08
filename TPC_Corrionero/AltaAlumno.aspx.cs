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
    public partial class AltaAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Alumnos alumno = new Alumnos();
            alumno.Nombre = txtNombre.Text;
            alumno.Apellido = txtApellido.Text;
            alumno.Dni = Convert.ToInt32(txtDni.Text);
            alumno.Mail = txtMail.Text;
            alumno.Telefono = Convert.ToInt32(txtTelefono.Text);
            alumno.Direccion = txtDireccion.Text;
            alumno.Legajo = Convert.ToInt64(txtLegajo.Text);
            AlumnosNegocio negocioAlumno = new AlumnosNegocio();
            if (negocioAlumno.AltaAlumno(alumno)== true)
            {
                Response.Write("<script>alert('Alumno creado con éxito!')</script>");
            }
            else
            {
                Session.Add("Error", "Hubo un error al ingresar el usuario.");
                Response.Redirect("PaginaError.aspx");
            }
            
            

        }
    }
}