<%@ Page Title="" Language="C#" MasterPageFile="~/ModeloMaster.Master" AutoEventWireup="true" CodeBehind="AltaMateria.aspx.cs" Inherits="TPC_Corrionero.AltaMateria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">

            <asp:TextBox ID="txtMateria" placeholder="Nombre Materia" runat="server"></asp:TextBox>
            <br />
            <asp:DropDownList ID="dropDownCarrera"  runat="server"></asp:DropDownList>

        </div>

    </div>

</asp:Content>
