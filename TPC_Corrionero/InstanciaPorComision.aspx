<%@ Page Title="" Language="C#" MasterPageFile="~/ModeloMaster.Master" AutoEventWireup="true" CodeBehind="InstanciaPorComision.aspx.cs" Inherits="TPC_Corrionero.InstanciaPorComision" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1> <asp:Label Text="Alumno: " runat="server" /> <asp:Label ID="lblAlumno" Text="" runat="server" /></h1>
    <br />
    <h2> <asp:Label Text="Comision: " runat="server" />
     <asp:Label ID="lblComision" Text="" runat="server" />

    </h2>
    <br />
    <div class="row" style="padding-left:30px;">
    <asp:Button ID="btnAgregar" CssClass="btn btn-outline-secondary" runat="server" Text="Agregar Instancia" OnClick="btnAgregar_Click" />

    </div>
</asp:Content>
