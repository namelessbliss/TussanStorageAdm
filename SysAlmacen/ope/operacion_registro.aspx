<%@ Page Title="" Language="C#" MasterPageFile="~/ope/Op.Master" AutoEventWireup="true" CodeBehind="operacion_registro.aspx.cs" Inherits="SysAlmacen.ope.operacion_registro1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--FORMULARIO DE REGISTRO DE USUARIO-->
    <div class="card text-center">
        <div class="card-block p-0 p-sm-4 p-md-4 p-xl-4">
            <h2>Registrar Guia</h2>

            <div id="formUsuario" class="justify-content-center">
                <div class="row">
                    <div class="form-group col-xl-12">
                        <p class=" h4">Seleccione Tipo de Guia:</p>
                        <asp:DropDownList ID="listaTipo" runat="server" class="form-control">
                        </asp:DropDownList>
                    </div>
                    <div class="form-group col-xl-12">
                        <p class=" h4">Seleccione Cliente Registrado:</p>
                        <asp:DropDownList ID="listaCliente" runat="server" class="form-control" AutoPostBack="true" OnSelectedIndexChanged="listaCliente_SelectedIndexChanged">
                            <asp:ListItem Enabled="True" Selected="true">Seleccione</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group col-xl-12">
                        <p class=" h4">Seleccione Mercaderia:</p>
                        <asp:DropDownList ID="listaMercaderia" runat="server" class="form-control">
                        </asp:DropDownList>
                    </div>
                    <div class="form-group col-12">
                        <asp:Calendar placeholder="Fecha" class="my-2" ID="calendario" runat="server" Visible="false" OnSelectionChanged="calendario_SelectionChanged"></asp:Calendar>
                        <asp:TextBox runat="server" placeholder="Fecha" class="form-control" ID="txtFecha" />
                        <asp:Button runat="server" Text="Seleccionar fecha" class=" mx-1 btn bg-primary text-white " ID="btnFecha" OnClick="btnFecha_Click" />
                    </div>
                    <div class="form-group col-12">
                        <p class=" h4">Ingrese cantidad:</p>
                        <asp:TextBox runat="server" type="number" placeholder="Cantidad" class="form-control" ID="txtCantidad" />
                    </div>
                    <div class="form-group col-12">
                        <p class=" h4">Ingrese Area Cubica Total:</p>
                        <asp:TextBox runat="server" type="text" placeholder="Area Cubica" class="form-control" ID="txtAreaCubica" />
                    </div>
                    <div class="col-12 py-2">
                        <div class="row justify-content-center">
                            <asp:Button runat="server" Text="Registrar Guia" class="btn bg-primary text-white col-6" ID="btnRegistrarRegistro" OnClick="btnRegistrarRegistro_Click" />
                        </div>
                    </div>
                </div>

                <div class="w3-container py-4">
                    <!--LISTA-->
                    <h5>Registros</h5>
                    <asp:GridView ID="RegistroList" runat="server" class="table table-striped table-light"
                        AllowPaging="true">
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
