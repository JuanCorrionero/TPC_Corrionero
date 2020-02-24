<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TPC_Corrionero.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">

    <title>Login</title>

    <style>
        .asd{
            background-color: lightgray;
            text-align: center;
            width: 80%;
            margin: 0 auto;
            padding: 10px;
            font-family:Calibri;
            border: 1px solid black;
        }

        .Contenedor{
            margin: 0 auto;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

            
                <div class="asd">
                    <h1>Sistema de Seguimiento Académico</h1>
                </div>
        <br />

        <div class="mx-auto" style="width: 30%">

        <div class="container">

    
<form>

  <div class="form-group">
    <label for="exampleInputEmail1">Número de Legajo</label>
     <asp:TextBox class="form-control" id="txtLegajo" aria-describedby="Legajo" runat="server"></asp:TextBox>
    <small id="emailHelp" class="form-text text-muted">Ingrese su número de legajo</small>
  </div>
  <div class="form-group">
    <label for="exampleInputPassword1">Contraseña</label>
     <asp:TextBox type="password" class="form-control" id="txtPass" runat="server"></asp:TextBox>
  </div>
  <div class="form-group form-check">
  </div>
    <asp:Button type="submit" id="btnEntrar" class="btn btn-primary" runat="server" Text="Entrar" OnClick="btnEntrar_Click" />


            <asp:Button type="submit" id="btnRegistrar" class="btn btn-primary" runat="server" Text="Registrarse" OnClick="btnRegistrar_Click"  />
        </div>
        </div>



    </form>

</form>

</body>
<script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
</html>
