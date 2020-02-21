<%@ Page Title="" Language="C#" MasterPageFile="~/ModeloMaster.Master" AutoEventWireup="true" CodeBehind="AltaMateria.aspx.cs" Inherits="TPC_Corrionero.AltaMateria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <style>
        .Ingresos{
            color: darkslategrey;
            background-color: #FDDB78;
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
        .cajita{
            margin-right: 10px;
        }

    </style>

            <h2 class="Ingresos">
            Ingrese el nombre de la materia y su carrera.
        </h2>
        <hr />

    <div class="container">
        <div class="row">
            
            <div class="cajita">
            <asp:TextBox ID="txtMateria" CssClass="form-control"  placeholder="Nombre Materia" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="ReqApellido" runat="server" ControlToValidate="txtMateria" ErrorMessage="Requiere completar"></asp:RequiredFieldValidator>
            </div>

            <div class="cajita">

            <asp:DropDownList ID="dropDownCarrera" Cssclass="form-control" runat="server"></asp:DropDownList>
            </div>
            <br />
        </div>
            <asp:Button CssClass="btn btn-dark" ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />

    </div>

</asp:Content>
