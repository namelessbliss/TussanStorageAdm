<%@ Page Title="" Language="C#" MasterPageFile="~/ope/Op.Master" AutoEventWireup="true" CodeBehind="acceso.aspx.cs" Inherits="SysAlmacen.ope.acceso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="w3-row-padding w3-margin-bottom">
        <div class="w3-quarter">
            <div class="w3-container w3-red w3-padding-16">
                <div class="w3-left"><i class="fa fa-comment w3-xxxlarge"></i></div>
                <div class="w3-right">
                    <h3></h3>
                </div>
                <div class="w3-clear"></div>
                <a href="mercaderia.aspx">
                    <h4 class="text-white">Mercaderias</h4>
                </a>
            </div>
        </div>

        <div class="w3-quarter">
            <div class="w3-container w3-blue w3-padding-16">
                <div class="w3-left"><i class="fa fa-eye w3-xxxlarge"></i></div>
                <div class="w3-right">
                    <h3></h3>
                </div>
                <div class="w3-clear"></div>
                <a href="operacion_registro.aspx">
                    <h4 class="text-white">Registros</h4>
                </a>
            </div>
        </div>

        <div class="w3-quarter">
            <div class="w3-container w3-teal w3-padding-16">
                <div class="w3-left"><i class="fa fa-share-alt w3-xxxlarge"></i></div>
                <div class="w3-right">
                    <h3></h3>
                </div>
                <div class="w3-clear"></div>
                <a href="cliente.aspx">
                    <h4 class="text-white">Clientes</h4>
                </a>
            </div>
        </div>

    </div>

    <!--LISTA -->
    <div class="w3-container">
        <!--LISTA DE CLIENTE-->
        <h5>Clientes Registrados</h5>
        <asp:GridView ID="ClienteList" runat="server" class="table table-striped table-light"
            AllowPaging="true">
        </asp:GridView>
    </div>
</asp:Content>
