<%@ Page Title="" Language="C#" MasterPageFile="~/ModeloMaster.Master" AutoEventWireup="true" CodeBehind="Observaciones.aspx.cs" Inherits="TPC_Corrionero.Observaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h2>
    
        <asp:Label ID="LblComision" Text="" runat="server" />  

    </h2>

    <br />

    <h2>
        <asp:Label ID="LblApellido"  Text="" runat="server" />
    </h2>

        <br />

    <h2>
        <asp:Label ID="LblInstancia" Text="" runat="server" />
    </h2>

    <br />

    <div>

    <asp:Button ID="btnAgregar" CssClass="btn btn-outline-dark" runat="server" Text="Agregar Observacion" OnClick="btnAgregar_Click" />

    </div>
    <br />

    <asp:GridView ID="dgvListaObservaciones" ShowHeaderWhenEmpty="true" CssClass="table table-striped table-secondary"
        AutoGenerateColumns="false"
         runat="server" >
        <Columns>
            <asp:BoundField HeaderText="Id" DataField="Id" />
            <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
            <%--<asp:TemplateField HeaderText="Opcion">
                    <ItemTemplate>
                        <asp:Button ID="btnAgregar" runat="server" Text="Ver observaciones"  CssClass="btn btn-outline-info" CausesValidation="False" 
                            CommandName="Agregar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
            </ItemTemplate>
             </asp:TemplateField>--%>
        </Columns>
    </asp:GridView>

</asp:Content>
