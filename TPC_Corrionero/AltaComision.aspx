<%@ Page Title="" Language="C#" MasterPageFile="~/ModeloMaster.Master" AutoEventWireup="true" CodeBehind="AltaComision.aspx.cs" Inherits="TPC_Corrionero.AltaComision" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <style>
        .Ingresos{
            color: darkslategrey;
            background-color: #40D7FC;
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

        label{
            color: lightgray;
            font-family: 'Times New Roman';
        }

    </style>

            <h2 class="Ingresos">
            Ingrese los datos de la comisión.
        </h2>
        <hr />


    <div class="container">
        <div class="row">
            <div class="col-4">
                <asp:Label Text="Nombre de la Comision:" runat="server" />
            <asp:TextBox ID="txtNombre" CssClass="form-control" placeholder="Nombre de la Comision" runat="server"></asp:TextBox>
                <br />
                    <asp:Label ID="lblMateria"  runat="server" Text="Materia: "></asp:Label></span>
                <asp:DropDownList ID="dwMateria" CssClass="form-control" runat="server"></asp:DropDownList>
            </div>
               </div>
        <br />
        <div class="row">
            <div class="col-2">
                <asp:Label Text="Cuatrimestre" runat="server" />
                    <asp:TextBox ID="txtCuatrimestre" placeholder="Cuatrimestre"  CssClass="form-control" runat="server"></asp:TextBox>
                <br />
                <span>
                    <asp:Label ID="lblTurnos" runat="server" Text="Turno: "></asp:Label></span>
                <asp:DropDownList ID="dwTurnos" CssClass="form-control" runat="server"></asp:DropDownList>
               </div>

        </div>
        <br />
        <asp:Button ID="btnAceptar" CssClass="btn btn-dark" runat="server" Text="Aceptar" OnClick="btnAceptar_Click"  />
                  </div>
        
</asp:Content>
