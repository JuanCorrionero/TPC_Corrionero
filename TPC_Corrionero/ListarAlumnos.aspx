<%@ Page Title="" Language="C#" MasterPageFile="~/ModeloMaster.Master" AutoEventWireup="true" CodeBehind="ListarAlumnos.aspx.cs" Inherits="TPC_Corrionero.ListarAlumnos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .Titulo{
            color: darkslategrey;
            background-color: #F1734E;
            text-align: center;
            border: 1px solid black;
            border-radius: 30px 15px;
            padding: 15px;
            width:60%;
            margin: auto;
        }


    </style>

    <br />
    <br />


    <h2 class="Titulo">
           Lista de todos los alumnos registrados
        </h2>

    <br />

    <div class="container">


    <asp:GridView runat="server" id="dgvAlumnos"
     ShowHeaderWhenEmpty="true" ShowFooterWhenEmpty="true"
     AutoGenerateColumns="false" cssclass="table table-striped table-dark" OnRowCommand="dgvAlumnos_RowCommand" >

        <Columns>
        <asp:BoundField HeaderText="Id" DataField="Id" />
         <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
         <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
         <asp:BoundField HeaderText="Mail" DataField="Mail" />

         <asp:TemplateField HeaderText="Opcion">
                    <ItemTemplate>
                        <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="btn btn-outline-warning" CausesValidation="false" 
                            CommandName="Modificar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                        
            </ItemTemplate>
             </asp:TemplateField>

          
    </Columns>

    </asp:GridView>

    </div>
</asp:Content>
