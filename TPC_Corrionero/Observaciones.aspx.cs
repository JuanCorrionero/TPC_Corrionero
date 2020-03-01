using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;
using System.Net.Mail;
using Dominio;
using Negocio;

namespace TPC_Corrionero
{
    public partial class Observaciones : System.Web.UI.Page
    {
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
                
                long IdComision = Convert.ToInt64(Session["IdComision"]);
                long IdAlumno = Convert.ToInt64(Session["IdAlumno"]);
                long IdInstancia = Convert.ToInt64(Session["IdInstancia"]);

                ObservacionesNegocio negocio = new ObservacionesNegocio();
                dgvListaObservaciones.DataSource = negocio.Listar(IdComision, IdAlumno, IdInstancia);
                dgvListaObservaciones.DataBind();
            }

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AltaObservacion.aspx");
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("InstanciaPorComision.aspx");
        }

       /* protected void btnMail_Click(object sender, EventArgs e)
        {
            AlumnosNegocio negocio = new AlumnosNegocio();
            long IdAlumno = Convert.ToInt64(Session["IdAlumno"]);
            
            Docentes docenteLogeado = new Docentes();
            docenteLogeado = (Docentes)Session["docenteLogeado"];

            string to = negocio.mailAlumno(IdAlumno); //To address    
            string from = docenteLogeado.Mail; //From address    
            MailMessage message = new MailMessage(from, to);

            string mailbody = 
;
            message.Subject = "Sending Email Using Asp.Net & C#";
            message.Body = mailbody;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential("yourmail id", "Password");
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
            }

            catch (Exception ex)
            {
                throw ex;
            }


        }*/


        protected void dgvListaObservaciones_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Mail")
            {
                int index = Convert.ToInt32(e.CommandArgument);

                //Reference the GridView Row.
                GridViewRow row = dgvListaObservaciones.Rows[index];

                string mail = row.Cells[1].Text;

                AlumnosNegocio negocio = new AlumnosNegocio();
                long IdAlumno = Convert.ToInt64(Session["IdAlumno"]);

                Docentes docenteLogeado = new Docentes();
                docenteLogeado = (Docentes)Session["docenteLogeado"];

                string to = negocio.mailAlumno(IdAlumno); //To address    
                string from = docenteLogeado.Mail; //From address    
                MailMessage message = new MailMessage(from, to);

                string mailbody = mail;
                message.Subject = "Observacion";
                message.Body = mailbody;
                message.BodyEncoding = System.Text.Encoding.UTF8;
                message.IsBodyHtml = true;
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
                System.Net.NetworkCredential basicCredential1 = new
                System.Net.NetworkCredential("yourmail id", "Password");
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = basicCredential1;
                try
                {
                    client.Send(message);
                }

                catch (Exception ex)
                {
                    throw ex;
                }


            }

            if (e.CommandName == "Editar")
            {
                int index = Convert.ToInt32(e.CommandArgument);

                //Reference the GridView Row.
                GridViewRow row = dgvListaObservaciones.Rows[index];

                long Id = Convert.ToInt64(row.Cells[0].Text);
                string obs = row.Cells[1].Text;

                Session.Add("IdObs", Id);
                Session.Add("Obs", obs);
                Response.Redirect("EditarObs.aspx");
            }

        }
    }
}