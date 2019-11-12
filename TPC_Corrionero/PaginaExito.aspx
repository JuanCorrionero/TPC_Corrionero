<%@ Page Title="" Language="C#" MasterPageFile="~/ModeloMaster.Master" AutoEventWireup="true" CodeBehind="PaginaExito.aspx.cs" Inherits="TPC_Corrionero.PaginaExito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">

        <div class="col-6">

             <p><% = Session["Exito" + Session.SessionID] %></p>
            <a class="btn btn-primary" style="margin-left: 150px; margin-bottom: 15px;" href="PagPrincipal.aspx">Aceptar</a>
        </div>
        </div>
    </div>
</asp:Content>
