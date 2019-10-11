﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Adm.master" AutoEventWireup="true" CodeBehind="usuario.aspx.cs" Inherits="SysAlmacen.usuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--FORMULARIO DE REGISTRO DE USUARIO-->
    <div class="card text-center">
        <div class="card-block p-0 p-sm-4 p-md-4 p-xl-4">
            <h2>Registrar Nuevo Usuario</h2>

            <form id="formUsuario" class="justify-content-center" runat="server">
                <div class="row">
                    <div class="form-group col-xl-12">
                        <asp:DropDownList ID="listaCargo" runat="server" placeholder="Cargo" class="form-control">
                            <asp:ListItem Value="1">Administrador</asp:ListItem>
                            <asp:ListItem Value="2">Operario</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group col-12">
                        <asp:TextBox runat="server" type="number" MaxLength="8" placeholder="DNI" class="form-control" ID="txtDNI"></asp:TextBox>
                    </div>
                    <div class="form-group col-12">
                        <asp:TextBox runat="server" type="text" placeholder="Nombre" class="form-control" ID="txtNombre"></asp:TextBox>
                    </div>
                    <div class="form-group col-12">
                        <asp:TextBox runat="server" type="text" placeholder="Usuario" class="form-control" ID="txtUsuario"></asp:TextBox>
                    </div>
                    <div class="form-group col-12">
                        <asp:TextBox runat="server" type="password" placeholder="Contraseña" class="form-control" ID="txtContraseña"></asp:TextBox>
                    </div>
                    <div class="col-12 py-2">
                        <div class="row justify-content-center">
                            <asp:Button runat="server" Text="Registrar Usuario" class="btn bg-primary text-white col-6" ID="btnRegistrarUsuario" OnClick="btnRegistrarUsuario_Click" />
                        </div>
                    </div>
                </div>

                <div class="w3-container">
                    <!--LISTA DE USUARIO-->
                    <h5>Usuarios Registrados</h5>
                    <asp:GridView ID="UserList" runat="server" class="table table-striped table-light"
                        AutoGenerateEditButton="True"
                        OnRowUpdating="OnRowUpdating">
                    </asp:GridView>
                </div>
                <hr>
            </form>
        </div>
    </div>
    <hr>
</asp:Content>
