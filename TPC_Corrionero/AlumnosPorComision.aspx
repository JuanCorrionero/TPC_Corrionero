<%@ Page Title="" Language="C#" MasterPageFile="~/ModeloMaster.Master" AutoEventWireup="true" CodeBehind="AlumnosPorComision.aspx.cs" Inherits="TPC_Corrionero.AlumnosPorComision" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <Center>
    <h2>
        <asp:label text="Comisión: " runat="server" />
    <asp:Label ID="lblNombreComision" runat="server" Text=""></asp:Label>
    </h2>
    </Center>

    <asp:GridView ID="dgvAlumnosPorComision" cssclass="table table-striped table-dark" AutoGenerateColumns="false" runat="server" OnRowCommand="dgvAlumnosPorComision_RowCommand">
        <Columns>
            <asp:BoundField HeaderText="Id" DataField="Id" />
            <asp:BoundField HeaderText="Legajo" DataField="Legajo" />
            <asp:BoundField HeaderText="Dni" DataField="Dni" />
            <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />

            <asp:TemplateField HeaderText="Opcion">
                    <ItemTemplate>
                        <asp:Button ID="btnInstancia" runat="server" Text="Ver Instancia Evaluativa" CssClass="btn btn-outline-info" CausesValidation="false" 
                            CommandName="VerInstancia" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                       
            </ItemTemplate>
             </asp:TemplateField>

        </Columns>
    </asp:GridView>
    <br />

    

    
</asp:Content>
