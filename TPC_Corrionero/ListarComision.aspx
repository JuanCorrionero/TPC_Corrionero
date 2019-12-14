<%@ Page Title="" Language="C#" MasterPageFile="~/ModeloMaster.Master" AutoEventWireup="true" CodeBehind="ListarComision.aspx.cs" Inherits="TPC_Corrionero.ListarComision" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
<asp:GridView id="dgvListaComision"
     ShowHeaderWhenEmpty="true" ShowFooterWhenEmpty="true"
    runat="server" AutoGenerateColumns="false" cssclass="table table-striped table-dark"
     OnRowCommand="dgvListaComision_RowCommand">
    
    <Columns>
        <asp:BoundField HeaderText="Id" DataField="Id" />
         <asp:BoundField HeaderText="Nombre Comi" DataField="Nombre" />
         <asp:BoundField HeaderText="Materia" DataField="Materia" />
         <asp:BoundField HeaderText="Turnos" DataField="Turno" />
         <asp:BoundField HeaderText="Cuatrimestre" DataField="Cuatrimestre" />
         <asp:TemplateField HeaderText="Opcion">
                    <ItemTemplate>
                        <asp:Button ID="btnVer" runat="server" Text="Ver Alumnos" CssClass="btn btn-outline-info" CausesValidation="false" 
                            CommandName="VerAlumnos" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                        <asp:Button ID="btnAgregar" runat="server" Text="Agregar Alumnos" CssClass="btn btn-outline-light" CausesValidation="false" 
                            CommandName="AgregarAlumno" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
            </ItemTemplate>
             </asp:TemplateField>

          
    </Columns>

</asp:GridView>

    

    
</asp:Content>
