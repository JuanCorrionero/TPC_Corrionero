<%@ Page Title="" Language="C#" MasterPageFile="~/ModeloMaster.Master" AutoEventWireup="true" CodeBehind="ListarComision.aspx.cs" Inherits="TPC_Corrionero.ListarComision" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
<asp:GridView id="dgvListaComision"
     ShowHeaderWhenEmpty="true" ShowFooterWhenEmpty="true" OnRowEditing="dgvListaComision_RowEditing"
    runat="server" AutoGenerateColumns="false" cssclass="table table-striped table-dark">

    <Columns>
         <asp:BoundField HeaderText="Nombre Comi" DataField="Nombre" />
         <asp:BoundField HeaderText="Materia" DataField="Materia" />
         <asp:BoundField HeaderText="Turnos" DataField="Turno" />
         <asp:BoundField HeaderText="Cuatrimestre" DataField="Cuatrimestre" />
         <asp:TemplateField HeaderText="Opcion">
                    <ItemTemplate>
                        <asp:ImageButton ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRjAmDB8_u7meopD9NGOVKxU55XyA7LvdERneW9DNO9FSBEt4M5qg&s" runat="server" CommandName="Edit" Tooltip="edit" width="20px" Height="20px"/>
                        <asp:ImageButton ImageUrl="~/Images/borrar.png" runat="server" CommandName="Delete" Tooltip="delete" width="20px" Height="20px"/>
                        </ItemTemplate>
                    <EditItemTemplate>
                       <asp:ImageButton ImageUrl="~/Images/guardar.png" runat="server" CommandName="Update" Tooltip="Update" width="20px" Height="20px"/>
                       <asp:ImageButton ImageUrl="~/Images/cancelar.png" runat="server" CommandName="Cancel" Tooltip="Cancel" width="20px" Height="20px"/>
                       
                    </EditItemTemplate>
                    <FooterTemplate>
                         <asp:ImageButton ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRjAmDB8_u7meopD9NGOVKxU55XyA7LvdERneW9DNO9FSBEt4M5qg&s" runat="server" CommandName="AddNew" Tooltip="AddNew" width="20px" Height="20px"/>
                    </FooterTemplate>
                    </asp:TemplateField>
         
          
    </Columns>

</asp:GridView>

    

    
</asp:Content>
