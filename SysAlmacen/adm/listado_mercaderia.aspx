<%@ Page Title="" Language="C#" MasterPageFile="~/adm/Amd.Master" AutoEventWireup="true" CodeBehind="listado_mercaderia.aspx.cs" Inherits="SysAlmacen.adm.listado_mercaderia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="w3-container py-5">
        <div>
            <!--LISTA -->
            <h4>Lista de Mercaderias Registradas</h4>
            <asp:GridView ID="UserList" runat="server" class="table table-striped table-light"
                AllowPaging="true"
                DataKeyNames="idMercaderia, idCliente"
                AutoGenerateEditButton="True"
                OnRowUpdating="OnRowUpdating"
                OnRowEditing="OnRowEditing"
                OnRowCancelingEdit="OnRowCancelingEdit">
            </asp:GridView>
        </div>
    </div>

</asp:Content>
