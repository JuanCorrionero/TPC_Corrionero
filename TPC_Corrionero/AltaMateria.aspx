<%@ Page Title="" Language="C#" MasterPageFile="~/ModeloMaster.Master" AutoEventWireup="true" CodeBehind="AltaMateria.aspx.cs" Inherits="TPC_Corrionero.AltaMateria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">
            <br />
            <asp:TextBox ID="txtMateria" placeholder="Nombre Materia" runat="server"></asp:TextBox>
            
            <asp:DropDownList ID="dropDownCarrera"  runat="server"></asp:DropDownList>
            <br />
            <asp:Button CssClass="btn btn-dark" ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
        </div>

    </div>

</asp:Content>
