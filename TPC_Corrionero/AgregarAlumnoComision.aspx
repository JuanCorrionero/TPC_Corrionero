<%@ Page Title="" Language="C#" MasterPageFile="~/ModeloMaster.Master" AutoEventWireup="true" CodeBehind="AgregarAlumnoComision.aspx.cs" Inherits="TPC_Corrionero.AgregarAlumnoComision" EnableEventValidation="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <center>
        <h1>
            <asp:label text="Comisión: " runat="server" />
            <asp:label ID="lblComision" text="" runat="server" />
        </h1>

    </center>

    <asp:GridView ID="dgvListaAlumnos" ShowHeaderWhenEmpty="true" CssClass="table table-striped table-secondary"
        AutoGenerateColumns="false"
         runat="server" OnRowCommand="dgvListaAlumnos_RowCommand">
        <Columns>
            <asp:BoundField HeaderText="Id" DataField="Id" />
            <asp:BoundField HeaderText="Legajo" DataField="Legajo" />
            <asp:BoundField HeaderText="Dni" DataField="Dni" />
            <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:TemplateField HeaderText="Opcion">
                    <ItemTemplate>
                        <asp:Button ID="btnAgregar" runat="server" Text="Agregar alumno"  CssClass="btn btn-outline-info" CausesValidation="False" 
                            CommandName="Agregar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
            </ItemTemplate>
             </asp:TemplateField>
        </Columns>
    </asp:GridView>

</asp:Content>
