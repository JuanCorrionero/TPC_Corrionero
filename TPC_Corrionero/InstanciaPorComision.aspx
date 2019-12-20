<%@ Page Title="" Language="C#" MasterPageFile="~/ModeloMaster.Master" AutoEventWireup="true" CodeBehind="InstanciaPorComision.aspx.cs" Inherits="TPC_Corrionero.InstanciaPorComision" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1> <asp:Label Text="Alumno: " runat="server" /> <asp:Label ID="lblAlumno" Text="" runat="server" /></h1>
    <br />
    <h2> <asp:Label Text="Comision: " runat="server" />
     <asp:Label ID="lblComision" Text="" runat="server" />

    </h2>
    <br />
    <div class="row" style="padding-left:30px;">
    <asp:Button ID="btnAgregar" CssClass="btn btn-outline-secondary" runat="server" Text="Agregar Instancia" OnClick="btnAgregar_Click" />

    </div>
    <br />
    <div>

                    <asp:GridView ID="dgvListaInstancias" ShowHeaderWhenEmpty="true" CssClass="table table-striped table-secondary"
        AutoGenerateColumns="false"
         runat="server" OnRowCommand="dgvListaInstancias_RowCommand" >
        <Columns>
            <asp:BoundField HeaderText="Id" DataField="Id" />
            <asp:BoundField HeaderText="Nombre Instancia" DataField="Nombre" />
            <asp:TemplateField HeaderText="Opcion">
                    <ItemTemplate>
                        <asp:Button ID="btnAgregar" runat="server" Text="Ver observaciones"  CssClass="btn btn-outline-info" CausesValidation="False" 
                            CommandName="Agregar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
            </ItemTemplate>
             </asp:TemplateField>
        </Columns>
    </asp:GridView>
    </div>
</asp:Content>
