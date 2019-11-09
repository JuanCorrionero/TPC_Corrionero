<%@ Page Title="" Language="C#" MasterPageFile="~/ModeloMaster.Master" AutoEventWireup="true" CodeBehind="AltaCarrera.aspx.cs" Inherits="TPC_Corrionero.AltaCarrera" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div style="background-color:black;color:white;">
            <h1>Ingrese el nombre de la Carrera</h1>

        </div>

        <div class="row">
            <div class="col-4">

        <br />
        <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server" placeholder="Carrera"></asp:TextBox>
        <br />
        <asp:Button ID="btnAceptar" CssClass="btn btn-outline-dark" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />

        </div>
            </div>
    </div>

</asp:Content>
