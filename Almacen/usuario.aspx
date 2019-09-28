<%@ Page Title="" Language="C#" MasterPageFile="~/Adm.master" AutoEventWireup="true" CodeFile="usuario.aspx.cs" Inherits="usuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <!--FORMULARIO DE REGISTRO DE USUARIO-->
    <div class="card text-center">
        <div class="card-block p-0 p-sm-4 p-md-4 p-xl-4">
            <h2>Registrar Nuevo Usuario</h2>

            <form id="formUsuario" class="justify-content-center" runat="server">
                <div class="row">
                    <div class="form-group col-xl-12">
                        <asp:DropDownList ID="listaCargo" placeholder="cargo" class="form-control" runat="server">
                            <asp:ListItem Value="1">Administrador</asp:ListItem>
                            <asp:ListItem Value="2">Operario</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group col-12">
                        <asp:TextBox runat="server" type="number" MaxLength="8" placeholder="DNI" class="form-control" ID="txtDNI" />
                    </div>
                    <div class="form-group col-12">
                        <asp:TextBox runat="server" type="text" placeholder="Nombre" class="form-control" ID="txtNombre" />
                    </div>
                    <div class="form-group col-12">
                        <asp:TextBox runat="server" type="text" placeholder="Usuario" class="form-control" ID="txtUsuario" />
                    </div>
                    <div class="form-group col-12">
                        <asp:TextBox runat="server" type="password" placeholder="Contraseña" class="form-control" ID="txtContraseña" />
                    </div>
                    <div class="col-12 py-2">
                        <div class="row justify-content-center">
                            <asp:Button runat="server" Text="Registrar Usuario" class="btn bg-primary text-white col-6" ID="btnRegistrarUsuario" />
                        </div>
                    </div>
                </div>
            </form>
            <!--CONTACTO-->
        </div>
    </div>
    <!--LISTA DE USUARIO-->
    <asp:DataList ID="UserList" runat="server"></asp:DataList>

    <hr>
    <div class="w3-container">
        <h5>Usuarios Registrados</h5>
        <ul class="w3-ul w3-card-4 w3-white">
            <li class="w3-padding-16">
                <img src="/img/user.png" class="w3-left w3-circle w3-margin-right" style="width: 35px">
                <span class="w3-xlarge">Adolfo</span><br>
            </li>
            <li class="w3-padding-16">
                <img src="/img/user.png" class="w3-left w3-circle w3-margin-right" style="width: 35px">
                <span class="w3-xlarge">Luis</span><br>
            </li>
            <li class="w3-padding-16">
                <img src="/img/user.png" class="w3-left w3-circle w3-margin-right" style="width: 35px">
                <span class="w3-xlarge">Sergio</span><br>
            </li>
        </ul>
    </div>
    <hr>
</asp:Content>

