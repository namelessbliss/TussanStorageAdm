<%@ Page Title="" Language="C#" MasterPageFile="~/adm/Adm.master" AutoEventWireup="true" CodeBehind="listado_mercaderia.aspx.cs" Inherits="SysAlmacen.adm.listado_mercaderia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="w3-container py-5">
        <form runat="server">
            <!--LISTA -->
            <h4>Mercaderia Registrada</h4>
            <asp:GridView ID="UserList" runat="server" class="table table-striped table-light"
                AllowPaging="true"
                DataKeyNames="idMercaderia, idCliente"
                AutoGenerateEditButton="True"
                OnRowUpdating="OnRowUpdating"
                OnRowEditing="OnRowEditing"
                OnRowCancelingEdit="OnRowCancelingEdit">
            </asp:GridView>
        </form>
    </div>

</asp:Content>
