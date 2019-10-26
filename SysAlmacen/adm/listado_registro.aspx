<%@ Page Title="" Language="C#" MasterPageFile="~/adm/Amd.Master" AutoEventWireup="true" CodeBehind="listado_registro.aspx.cs" Inherits="SysAlmacen.adm.listado_registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-control my-2">
        <h4>Tipo de guia:</h4>
        <asp:DropDownList ID="listaTipoGuia" runat="server" AutoPostBack="true" OnSelectedIndexChanged="listaTipoGuia_SelectedIndexChanged">
            <asp:ListItem Value="1">Guia de entrada</asp:ListItem>
            <asp:ListItem Value="2">Guia de salida</asp:ListItem>
        </asp:DropDownList>
    </div>
    <div class="w3-container py-5">
        <div>
            <!--LISTA -->
            <h4>Lista de Guias Registradas</h4>
            <asp:GridView ID="GuiaList" runat="server" class="table table-striped table-light"
                AllowPaging="true">
            </asp:GridView>
        </div>
    </div>
</asp:Content>
