<%@ Page Title="" Language="C#" MasterPageFile="~/ModeloMaster.Master" AutoEventWireup="true" CodeBehind="AltaObservacion.aspx.cs" Inherits="TPC_Corrionero.AltaObservacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />

    <h2>Escriba la observacion de la instancia evaluativa: </h2>
    <br />

    <asp:TextBox ID="txtDescripcion"  Width="300px" CssClass="form form-control" runat="server"></asp:TextBox>

    <br />
    <asp:Button ID="btnAceptar" CssClass="btn btn-outline-success" OnClick="btnAceptar_Click" runat="server" Text="Aceptar" />

</asp:Content>
