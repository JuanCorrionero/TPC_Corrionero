<%@ Page Title="" Language="C#" MasterPageFile="~/ModeloMaster.Master" AutoEventWireup="true" CodeBehind="AltaComision.aspx.cs" Inherits="TPC_Corrionero.AltaComision" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div style="background-color:black;color:white;">
            <h1>Ingrese los datos de la comision</h1>
            <br />
        </div>

    <br />

    <div class="container">
        <div class="row">
            <div class="col-4">
            <asp:TextBox ID="txtNombre" CssClass="form-control" placeholder="Nombre de la Comision" runat="server"></asp:TextBox>
                <br />
                <span>
                    <asp:Label ID="lblMateria" runat="server" Text="Materia: "></asp:Label></span>
                <asp:DropDownList ID="dwMateria" runat="server"></asp:DropDownList>
            </div>
               </div>
        <br />
        <div class="row">
            <div class="col-2">
                    <asp:TextBox ID="txtCuatrimestre" placeholder="Cuatrimestre"  CssClass="form-control" runat="server"></asp:TextBox>
                <br />
                <span>
                    <asp:Label ID="lblTurnos" runat="server" Text="Turno: "></asp:Label></span>
                <asp:DropDownList ID="dwTurnos" runat="server"></asp:DropDownList>
               </div>

        </div>
        <br />
        <asp:Button ID="btnAceptar" CssClass="btn btn-dark" runat="server" Text="Aceptar" OnClick="btnAceptar_Click"  />
                  </div>
        
</asp:Content>
