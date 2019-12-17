<%@ Page Title="" Language="C#" MasterPageFile="~/ModeloMaster.Master" AutoEventWireup="true" CodeBehind="PaginaError.aspx.cs" Inherits="TPC_Corrionero.PaginaError" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <p><% = Session["Error"] %></p>
            <a class="btn btn-primary" style="margin-left: 150px; margin-bottom: 15px;" href="PagPrincipal.aspx">Aceptar</a>
</asp:Content>
