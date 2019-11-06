<%@ Page Title="" Language="C#" MasterPageFile="~/ModeloMaster.Master" AutoEventWireup="true" CodeBehind="AltaAlumno.aspx.cs" Inherits="TPC_Corrionero.AltaAlumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container"> 
        <div class="container-fluid">
        <h2>
            Ingrese los datos
        </h2>
  
</div>

        <div class="row">
            <%-- Texto Nombre y apellido --%>
            <div class="col-3">

                <asp:TextBox ID="txtNombre" CssClass="form-control" placeholder="Nombre" runat="server"></asp:TextBox>



                <asp:TextBox ID="txtApellido" CssClass="form-control" placeholder="Apellido" runat="server"></asp:TextBox>

                </div>
            <%-- Texto Nombre y Apellido --%>

            <%-- Texto Dni y Email --%>
            <div class="row">

                        <div class="col-6">


                <asp:TextBox ID="txtDni" CssClass="form-control" placeholder="Documento" runat="server"></asp:TextBox>
                <asp:TextBox ID="txtMail" CssClass="form-control" placeholder="E-mail" runat="server"></asp:TextBox>

                        </div>
                     
                     <div class="col-6">
                <asp:TextBox ID="txtTelefono" CssClass="form-control" placeholder="Telefono" runat="server"></asp:TextBox>

                <asp:TextBox ID="txtDireccion" CssClass="form-control" placeholder="Direccion" runat="server"></asp:TextBox>

                     </div>

            </div>



        </div>

    </div>

</asp:Content>
