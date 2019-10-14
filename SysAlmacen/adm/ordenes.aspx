<%@ Page Title="" Language="C#" MasterPageFile="~/adm/Adm.master" AutoEventWireup="true" CodeFile="ordenes.aspx.cs" Inherits="ordenes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!--LISTA DE USUARIO-->
    <hr>
    <div class="w3-container">
        <h5>Lista de ordenes</h5>
        <ul class="w3-ul w3-card-4 w3-white">
            <li class="w3-padding-16">
                <img src="/img/user.png" class="w3-left w3-circle w3-margin-right" style="width: 35px">
                <span class="w3-xlarge">Orden nº 1</span><br>
            </li>
            <li class="w3-padding-16">
                <img src="/img/user.png" class="w3-left w3-circle w3-margin-right" style="width: 35px">
                <span class="w3-xlarge">Orden nº 2</span><br>
            </li>
            <li class="w3-padding-16">
                <img src="/img/user.png" class="w3-left w3-circle w3-margin-right" style="width: 35px">
                <span class="w3-xlarge">Orden nº 3</span><br>
            </li>
        </ul>
    </div>
    <hr>
</asp:Content>

