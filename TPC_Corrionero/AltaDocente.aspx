<%@ Page Title="" Language="C#" MasterPageFile="~/ModeloMaster.Master" AutoEventWireup="true" CodeBehind="AltaDocente.aspx.cs" Inherits="TPC_Corrionero.AltaDocente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container"> 
        <div style="background-color:black;color:white;padding:20px;">
        <h2>
            Ingrese los datos del docente.
        </h2>
  
</div>
        <hr />

        <div class="row">
            <%-- Texto Nombre y apellido --%>
            <div class="col-3">

                <asp:TextBox ID="txtNombre" CssClass="form-control" placeholder="Nombre" runat="server"></asp:TextBox>
                <br />
                <asp:TextBox ID="txtApellido" CssClass="form-control" placeholder="Apellido" runat="server"></asp:TextBox>

                <br />

                <asp:TextBox ID="txtLegajo" CssClass="form-control" placeholder="Legajo" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="btnAceptar" CssClass="btn btn-outline-dark" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />

                </div>
           
            <%-- Texto Nombre y Apellido --%>

            <%-- Texto Dni y Email --%>
            <div class="row">

                        <div class="col-6">


                <asp:TextBox ID="txtDni" CssClass="form-control" placeholder="Documento" runat="server"></asp:TextBox>
                <br />
                <asp:TextBox ID="txtMail" CssClass="form-control" placeholder="E-mail" runat="server"></asp:TextBox>
                        </div>
                     <div class="col-6">
                <asp:TextBox ID="txtTelefono" CssClass="form-control" placeholder="Telefono" runat="server"></asp:TextBox>
                         <br />
                <asp:TextBox ID="txtDireccion" CssClass="form-control" placeholder="Direccion" runat="server"></asp:TextBox>


                     </div>

            </div>



        </div>

    </div>

</asp:Content>
