<%@ Page Title="" Language="C#" MasterPageFile="~/ModeloMaster.Master" AutoEventWireup="true" CodeBehind="AltaObservacion.aspx.cs" Inherits="TPC_Corrionero.AltaObservacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />

    <style>
        .container{
            width: 80%;
        }

        .botonVolver{
            float: right;
        }

        .titulo{

            
            border: 1px solid black;
            border-radius: 25px 10px;
            background-color: lightgray;
            color: darkslategrey;
            
            padding: 10px;

        }

    </style>

  <div class="container">
      
        <div class="titulo">
            <h1>Ingrese la observacion de esta instancia evaluativa.</h1>
            <br />
        </div>
    <br />
              <div class="botonVolver">

            <asp:Button ID="btnVolver" CssClass="btn btn-outline-secondary" runat="server" Text="Volver" OnClick="btnVolver_Click" />
        </div>

    <asp:TextBox ID="txtDescripcion"  Width="300px" CssClass="form form-control" placeholder="Observación" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="ReqDescripcion" runat="server" ControlToValidate="txtDescripcion" ErrorMessage="Requiere completar"></asp:RequiredFieldValidator>
    <br />

    <asp:Button ID="btnAceptar" CssClass="btn btn-outline-success" OnClick="btnAceptar_Click" runat="server" Text="Aceptar" />
      </div>
</asp:Content>
