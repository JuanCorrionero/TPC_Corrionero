<%@ Page Title="" Language="C#" MasterPageFile="~/ModeloMaster.Master" AutoEventWireup="true" CodeBehind="AltaDocente.aspx.cs" Inherits="TPC_Corrionero.AltaDocente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        .Ingresos{
            color: darkslategrey;
            background-color: #B5F337;
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

    </style>

            <h2 class="Ingresos">
            Ingrese los datos del docente.
        </h2>
        <hr />

    <div class="container">


        <div class="row">
            <%-- Texto Nombre y apellido --%>
            <div class="col-3">

                <asp:TextBox ID="txtNombre" CssClass="form-control" placeholder="Nombre" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="ReqDni" runat="server" ControlToValidate="txtDni" ErrorMessage="Requiere completar"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegExpValDni" runat="server" ControlToValidate="txtDni" ErrorMessage="Sólamente debe contener números" ValidationExpression="\d+"></asp:RegularExpressionValidator>
                <br />
                <asp:TextBox ID="txtApellido" CssClass="form-control" placeholder="Apellido" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="ReqApellido" runat="server" ControlToValidate="txtApellido" ErrorMessage="Requiere completar"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegExpValApellido" runat="server" ControlToValidate="txtApellido" ValidationExpression="^[a-zA-Z ]*$" ErrorMessage="El apellido sólamente debe contener letras"></asp:RegularExpressionValidator>
                <br />

                <asp:TextBox ID="txtLegajo" CssClass="form-control" placeholder="Legajo" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="ReqValLegajo" runat="server" ControlToValidate="txtLegajo" ErrorMessage="Requiere completar"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegExpValLegajo" runat="server" ControlToValidate="txtLegajo" ErrorMessage="Sólamente debe contener números" ValidationExpression="\d+"></asp:RegularExpressionValidator>
                <br />
                <asp:TextBox ID="txtPass" CssClass="form-control" type="password" placeholder="Contraseña" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Requiere completar" ControlToValidate="txtPass"></asp:RequiredFieldValidator>
                <br />

                <asp:Button ID="btnAceptar" CssClass="btn btn-outline-dark" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />

                </div>
           
            <%-- Texto Nombre y Apellido --%>

            <%-- Texto Dni y Email --%>
            <div class="row">

                        <div class="col-6">


                <asp:TextBox ID="txtDni" CssClass="form-control" placeholder="Documento" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtDni" ErrorMessage="Requiere completar"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtDni" ErrorMessage="Sólamente debe contener números" ValidationExpression="\d+"></asp:RegularExpressionValidator>
                <br />
                <asp:TextBox ID="txtMail" CssClass="form-control" placeholder="E-mail" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="ReqMail" runat="server" ErrorMessage="Requiere completar" ControlToValidate="txtMail"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegExpValMail" runat="server" ErrorMessage="Ingresar mail de forma correcta." ControlToValidate="txtMail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        </div>
                     <div class="col-6">
                <asp:TextBox ID="txtTelefono" CssClass="form-control" placeholder="Telefono" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="reqTelefono" runat="server" ControlToValidate="txtTelefono" ErrorMessage="Requiere completar"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegExpValTelefono" runat="server" ControlToValidate="txtTelefono" ErrorMessage="Sólamente debe contener números" ValidationExpression="\d+"></asp:RegularExpressionValidator>
                         <br />
                <asp:TextBox ID="txtDireccion" CssClass="form-control" placeholder="Direccion" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RegDireccion" runat="server" ErrorMessage="Requiere completar" ControlToValidate="txtDireccion"></asp:RequiredFieldValidator>

                <asp:CheckBox ID="chkLogin" class="form-check-label" text="Es admin?" runat="server" />

                     </div>

            </div>



        </div>

    </div>

</asp:Content>
