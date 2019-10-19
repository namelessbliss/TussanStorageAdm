﻿<%@ Page Title="" Language="C#" MasterPageFile="~/adm/Adm.master" AutoEventWireup="true" CodeBehind="resumen.aspx.cs" Inherits="SysAlmacen.adm.resumen1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="w3-row-padding w3-margin-bottom">
        <div class="w3-quarter">
            <div class="w3-container w3-red w3-padding-16">
                <div class="w3-left"><i class="fa fa-comment w3-xxxlarge"></i></div>
                <div class="w3-right">
                    <h3>52</h3>
                </div>
                <div class="w3-clear"></div>
                <h4>Paquetes</h4>
            </div>
        </div>
        <!--
            <div class="w3-quarter">
                <div class="w3-container w3-blue w3-padding-16">
                    <div class="w3-left"><i class="fa fa-eye w3-xxxlarge"></i></div>
                    <div class="w3-right">
                        <h3>99</h3>
                    </div>
                    <div class="w3-clear"></div>
                    <h4>Views</h4>
                </div>
            </div>
                -->
        <!--
            <div class="w3-quarter">
                <div class="w3-container w3-teal w3-padding-16">
                    <div class="w3-left"><i class="fa fa-share-alt w3-xxxlarge"></i></div>
                    <div class="w3-right">
                        <h3>23</h3>
                    </div>
                    <div class="w3-clear"></div>
                    <h4>Shares</h4>
                </div>
            </div>
                -->
        <div class="w3-quarter">
            <div class="w3-container w3-orange w3-text-white w3-padding-16">
                <div class="w3-left"><i class="fa fa-users w3-xxxlarge"></i></div>
                <div class="w3-right">
                    <h3>50</h3>
                </div>
                <div class="w3-clear"></div>
                <h4>Usuarios</h4>
            </div>
        </div>
    </div>

    <!--LISTA DE USUARIO-->
    <hr>
    <form runat="server">
        <div class="w3-container py-2">
            <!--LISTA DE USUARIO-->
            <h5>Usuarios Registrados</h5>
            <asp:GridView ID="UserList" runat="server" class="table table-striped table-light"
                AllowPaging="true">
            </asp:GridView>
        </div>

        <div class="w3-container py-2">
            <!--LISTA DE CLIENTE-->
            <h5>Clientes Registrados</h5>
            <asp:GridView ID="ClienteList" runat="server" class="table table-striped table-light"
                AllowPaging="true">
            </asp:GridView>
        </div>

        <div class="w3-container py-2">
            <!--LISTA DE TRANSPORTISTA-->
            <h5>Transportistas Registrados</h5>
            <asp:GridView ID="TransportistaList" runat="server" class="table table-striped table-light"
                AllowPaging="true">
            </asp:GridView>
        </div>
    </form>
    <hr>
</asp:Content>
