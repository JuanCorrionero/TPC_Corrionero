<%@ Page Title="" Language="C#" MasterPageFile="~/ModeloMaster.Master" AutoEventWireup="true" CodeBehind="PagPrincipal.aspx.cs" Inherits="TPC_Corrionero.PagPrincipal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <br />
    <div class="row">

    <div class="card" style="width: 18rem; padding-left:10px;">
  <img src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRbeMMrnxFMOmymXkDeIopIJnZINT-vO99y68cF9gDSgsrVWiFM&s" class="card-img-top" alt="...">
  <div class="card-body">
    <h5 class="card-title">Agregar Alumno</h5>
    <p class="card-text">Haga click en el botón para agregar un alumno</p>
    <a href="AltaAlumno.aspx" class="btn btn-primary">Agregar Alumno</a>
  </div>
</div>

        <div class="card" style="width: 18rem; padding-left:20px;">
  <img src="https://png.pngtree.com/svg/20141030/teacher_837945.png" class="card-img-top" alt="...">
  <div class="card-body">
    <h5 class="card-title">Agregar Docente</h5>
    <p class="card-text">Haga click en el boton para agregar un docente</p>
    <a href="AltaDocente.aspx" class="btn btn-primary">Agregar Docente</a>
  </div>
</div>

            <div class="card" style="width: 18rem; padding-left:20px;">
  <img src="https://www.nicepng.com/png/full/239-2399102_libros-materias-icon.png" class="card-img-top" alt="...">
  <div class="card-body">
    <h5 class="card-title">Agregar Materia</h5>
    <p class="card-text">Haga click en el boton para agregar una materia</p>
    <a href="AltaMateria.aspx" class="btn btn-primary">Agregar Materia</a>
  </div>
</div>

                <div class="card" style="width: 18rem; padding-left:20px;">
  <img src="https://www.svgrepo.com/show/90040/classroom.svg" class="card-img-top" alt="...">
  <div class="card-body">
    <h5 class="card-title">Agregar Comisión</h5>
    <p class="card-text">Haga click en el boton para agregar una comisión</p>
    <a href="AltaComision.aspx" class="btn btn-primary">Agregar comisión</a>
  </div>
</div>

                        <div class="card" style="width: 18rem; padding-left:20px;">
  <img src="https://www.svgrepo.com/show/31828/college-classroom.svg" class="card-img-top" alt="...">
  <div class="card-body">
    <h5 class="card-title">Ver Comisiones</h5>
    <p class="card-text"></p>
    <a href="ListarComision.aspx" class="btn btn-primary">Ver comisiones</a>
  </div>
</div>



    </div>

</asp:Content>

