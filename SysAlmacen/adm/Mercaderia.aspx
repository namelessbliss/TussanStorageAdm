<%@ Page Title="" Language="C#" MasterPageFile="~/adm/Adm.master" AutoEventWireup="true" CodeBehind="mercaderia.aspx.cs" Inherits="SysAlmacen.adm.Mercaderia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--FORMULARIO DE REGISTRO DE USUARIO-->
    <div class="card text-center">
        <div class="card-block p-0 p-sm-4 p-md-4 p-xl-4">
            <h2>Registrar Nuevo Mercaderia de Cliente</h2>

            <form id="formUsuario" class="justify-content-center" runat="server">
                <div class="row">
                    <div class="form-group col-xl-12">
                        <asp:DropDownList ID="listaClientes" runat="server" placeholder="Cargo" class="form-control">
                        </asp:DropDownList>
                    </div>
                    <div class="form-group col-12">
                        <asp:TextBox runat="server" type="text" placeholder="Descripcion" class="form-control" ID="txtDescripcion"></asp:TextBox>
                    </div>
                    <div class="form-group col-12">
                        <asp:TextBox runat="server" type="number" step="0.01" placeholder="Area Cubica" class="form-control" ID="txtAreaCubica"></asp:TextBox>
                    </div>
                    <div class="form-group col-12">
                        <asp:TextBox runat="server" type="number" placeholder="Cantidad" class="form-control" ID="txtCantidad"></asp:TextBox>
                    </div>
                    <div class="col-12 py-2">
                        <div class="row justify-content-center">
                            <asp:Button runat="server" Text="Registrar Mercaderia" class="btn bg-primary text-white col-6" ID="btnRegistrarMerca" OnClick="btnRegistrarMerca_Click" />
                        </div>
                    </div>
                </div>
                <br />
                <asp:Label ID="mensaje" runat="server" Text="" class="alert display-4"></asp:Label>
                <div class="w3-container py-5">
                </div>
                <hr>
            </form>
        </div>
    </div>
    <hr>
</asp:Content>
