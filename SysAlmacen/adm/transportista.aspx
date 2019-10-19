<%@ Page Title="" Language="C#" MasterPageFile="~/adm/Adm.master" AutoEventWireup="true" CodeBehind="transportista.aspx.cs" Inherits="SysAlmacen.adm.transportista" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--FORMULARIO DE REGISTRO -->
    <div class="card text-center">
        <div class="card-block p-0 p-sm-4 p-md-4 p-xl-4">
            <h2>Registrar Nuevo Transportista con su vehiculo</h2>

            <form id="formUsuario" class="justify-content-center" runat="server">
                <div class="row">
                    <div class="form-group col-12">
                        <asp:TextBox runat="server" type="number" MaxLength="8" placeholder="DNI" class="form-control" ID="txtDNI"></asp:TextBox>
                    </div>
                    <div class="form-group col-12">
                        <asp:TextBox runat="server" type="text" placeholder="Nombre" class="form-control" ID="txtNombre"></asp:TextBox>
                    </div>
                    <div class="form-group col-12">
                        <asp:TextBox runat="server" type="text" placeholder="Placa del vehiculo" class="form-control" ID="txtPlaca"></asp:TextBox>
                    </div>
                    <div class="col-12 py-2">
                        <div class="row justify-content-center">
                            <asp:Button runat="server" Text="Registrar Transportista" class="btn bg-primary text-white col-6" ID="btnRegistrarTransportista" OnClick="btnRegistrarTransportista_Click" />
                        </div>
                    </div>
                </div>

                <div class="w3-container">
                    <!--LISTA -->
                    <h5>Transportistas Registrados</h5>
                    <asp:GridView ID="UserList" runat="server" class="table table-striped table-light"
                        AllowPaging="true"
                        DataKeyNames="TransportistaDNI"
                        AutoGenerateEditButton="True"
                        OnRowUpdating="OnRowUpdating"
                        OnRowEditing="OnRowEditing"
                        OnRowCancelingEdit="OnRowCancelingEdit">
                    </asp:GridView>
                </div>
                <hr>
            </form>
        </div>
    </div>
</asp:Content>
