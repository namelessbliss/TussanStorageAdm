<%@ Page Title="" Language="C#" MasterPageFile="~/ope/Op.Master" AutoEventWireup="true" CodeBehind="cliente.aspx.cs" Inherits="SysAlmacen.ope.cliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--FORMULARIO DE REGISTRO DE CLIENTE-->
    <div class="card text-center">
        <div class="card-block p-0 p-sm-4 p-md-4 p-xl-4">
            <h2>Registrar Nuevo Cliente</h2>

            <div id="formUsuario" class="justify-content-center">
                <div class="row">
                    <div class="form-group col-12">
                        <p class=" h5">Ingrese nombre de la empresa:</p>
                        <asp:TextBox runat="server" type="text" MaxLength="8" placeholder="Nombre Empresa" class="form-control" ID="txtEmpresa"></asp:TextBox>
                    </div>
                    <div class="form-group col-12">
                        <p class=" h5">Ingrese dueño de la empresa:</p>
                        <asp:TextBox runat="server" type="text" placeholder="Dueño" class="form-control" ID="txtDueño"></asp:TextBox>
                    </div>
                    <div class="form-group col-12">
                        <p class=" h5">Ingrese RUC:</p>
                        <asp:TextBox runat="server" type="number" placeholder="RUC" class="form-control" ID="txtRUC"></asp:TextBox>
                    </div>
                    <div class="col-12 py-4">
                        <div class="row justify-content-center">
                            <asp:Button ID="btnRegistrarCliente" runat="server" Text="Registrar Cliente" class="btn bg-primary text-white col-6" OnClick="btnRegistrarCliente_Click" />
                        </div>

                    </div>
                </div>

                <div class="w3-container">
                    <!--LISTA DE CLIENTE-->
                    <h5>Clientes Registrados</h5>
                    <asp:GridView ID="ClienteList" runat="server" class="table table-striped table-light"
                        AllowPaging="true">
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
