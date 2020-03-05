<%@ Page Title="" Language="C#" MasterPageFile="~/ModeloMaster.Master" AutoEventWireup="true" CodeBehind="AlumnosPorComision.aspx.cs" Inherits="TPC_Corrionero.AlumnosPorComision" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <style>

        .container{
            width: 80%;
        }

        .titulo{

            
            border: 1px solid black;
            border-radius: 25px 10px;
            background-color: darkslategrey;
            color: lightblue;
            width: auto;
            padding: 10px;

        }




    </style>

    <div class="container" >


    <h2 class="titulo">
        <asp:label text="Comisión: " CssClass="txtTitulo" runat="server" />
    <asp:Label ID="lblNombreComision" runat="server" Text=""></asp:Label>
    </h2>
    
        <br />

        <div style="float: right;">
        <asp:Button ID="BotonVolver" Text="Volver" CssClass="btn btn-outline-secondary" OnClick="BotonVolver_Click" runat="server" />
        </div>

        <br />
        </div>

        <div class="container">
            <br />

            <%-- Grid view de alumnos ACTIVOS --%>

    <asp:GridView ID="dgvAlumnosPorComision" cssclass="table table-striped table-dark" AutoGenerateColumns="false" runat="server" OnRowCommand="dgvAlumnosPorComision_RowCommand">
        <Columns>
            <asp:BoundField HeaderText="Id" DataField="Id" />
            <asp:BoundField HeaderText="IdComision" DataField="IdComision" />
            <asp:BoundField HeaderText="Legajo" DataField="Legajo" />
            <asp:BoundField HeaderText="Dni" DataField="Dni" />
            <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />

            <asp:TemplateField HeaderText="Opcion">
                    <ItemTemplate>
                        <asp:Button ID="btnInstancia" runat="server" Text="Ver Instancia Evaluativa" CssClass="btn btn-outline-info" CausesValidation="false" 
                            CommandName="VerInstancia" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                        <asp:Button ID="btnBaja" runat="server" Text="Baja alumno" CssClass="btn btn-outline-danger" CausesValidation="false" 
                            CommandName="BajaAlumno" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                       
            </ItemTemplate>
             </asp:TemplateField>

        </Columns>
    </asp:GridView>

                        <%-- Grid view de alumnos DADOS DE BAJA --%>
            <br />
            <br />

            <asp:GridView ID="dgvBaja" cssclass="table table-striped table-dark" AutoGenerateColumns="false" runat="server" onRowCommand="dgvBaja_RowCommand">
        <Columns>
            <asp:BoundField HeaderText="Id" DataField="Id" />
            <asp:BoundField HeaderText="IdComision" DataField="IdComision" />
            <asp:BoundField HeaderText="Legajo" DataField="Legajo" />
            <asp:BoundField HeaderText="Dni" DataField="Dni" />
            <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />

            <asp:TemplateField HeaderText="Opcion">
                    <ItemTemplate>
                        <asp:Button ID="btnAlta" runat="server" Text="Reingresar alumno" CssClass="btn btn-outline-success" CausesValidation="false" 
                            CommandName="ReIngresar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                       
                       
            </ItemTemplate>
             </asp:TemplateField>

        </Columns>
    </asp:GridView>
    

    

    </div>
    
</asp:Content>
