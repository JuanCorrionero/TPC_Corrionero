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
            CarreraNegocio carreraNegocio = new CarreraNegocio();
            dropDownCarrera.DataSource = carreraNegocio.listar();
            dropDownCarrera.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Materia materia = new Materia();
            MateriaNegocio negocio = new MateriaNegocio();
            materia.Nombre = txtMateria.Text;
            // TODO: Revisar como traer la informacion del dropdownlist para traer el objeto o al menos la info.
            materia.Carrera = (Carrera)dropDownCarrera.SelectedItem;

        }
    }
}