﻿<%@ Page Title="" Language="C#" MasterPageFile="~/ModeloMaster.Master" AutoEventWireup="true" CodeBehind="AgregarInstancia.aspx.cs" Inherits="TPC_Corrionero.AgregarInstancia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
<div class="container">
        <div style="background-color:black;color:white;">
            <h1>Ingrese el nombre de la instancia evaluativa</h1>
            <br />
        </div>    <br />

    <div class="container">

    <div class="row" >
        <div class="col-4">

            <span>

        <asp:Label ID="lblInst" CssClass="text-capitalize" runat="server" Text="Ingrese el nombre de la Instancia Evaluativa: "></asp:Label>
            <asp:TextBox ID="txtInstancia" CssClass="form-control" runat="server"  Width="350px" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="ReqApellido" runat="server" ControlToValidate="txtInstancia" ErrorMessage="Requiere completar"></asp:RequiredFieldValidator>
            </span>

        </div>
        </div>
    </div>
    <br />
    <div class="row">
        <div style="text-align:left; padding-left:20px;">

    <asp:Button ID="btnAceptar" CssClass="btn btn-outline-success" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
        </div>

    </div>

    <div class="container">  
        <div class="row">




           

        </div>

    </div>

        </asp:Content>
