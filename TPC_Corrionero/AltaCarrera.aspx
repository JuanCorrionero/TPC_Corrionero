<%@ Page Title="" Language="C#" MasterPageFile="~/ModeloMaster.Master" AutoEventWireup="true" CodeBehind="AltaCarrera.aspx.cs" Inherits="TPC_Corrionero.AltaCarrera" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>
        .Ingresos{
            color: white;
            background-color: #021D37;
            text-align: center;
            border: 1px solid black;
            border-radius: 30px 15px;
            padding: 15px;
            width:60%;
            margin: auto;
        }

        hr{
            width:90%;
        }

        .container{
            margin:auto;
        }

    </style>

            <h2 class="Ingresos">
            Ingrese el nombre de la carrera.
        </h2>
        <hr />


    <div class="container">
        <div class="row">
            <div class="col-4">

        
        <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server" placeholder="Carrera"></asp:TextBox>
        <asp:RequiredFieldValidator ID="ReqApellido" runat="server" ControlToValidate="txtNombre" ErrorMessage="Requiere completar"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegExpValApellido" runat="server" ControlToValidate="txtNombre" ValidationExpression="^[a-zA-Z ]*$" ErrorMessage="El apellido sólamente debe contener letras"></asp:RegularExpressionValidator>
        <br />
        <asp:Button ID="btnAceptar" CssClass="btn btn-outline-dark" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />

        </div>
            </div>
    </div>

</asp:Content>
