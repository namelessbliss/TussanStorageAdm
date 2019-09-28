<%@ Page Title="" Language="C#" MasterPageFile="~/Adm.master" AutoEventWireup="true" CodeFile="resumen.aspx.cs" Inherits="resumen" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
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
    <div class="w3-container">
        <h5>Usuarios Registrados</h5>
        <ul class="w3-ul w3-card-4 w3-white">
            <li class="w3-padding-16">
                <img src="/img/user.png" class="w3-left w3-circle w3-margin-right" style="width: 35px">
                <span class="w3-xlarge">Adolfo</span><br>
            </li>
            <li class="w3-padding-16">
                <img src="/img/user.png" class="w3-left w3-circle w3-margin-right" style="width: 35px">
                <span class="w3-xlarge">Luis</span><br>
            </li>
            <li class="w3-padding-16">
                <img src="/img/user.png" class="w3-left w3-circle w3-margin-right" style="width: 35px">
                <span class="w3-xlarge">Sergio</span><br>
            </li>
        </ul>
    </div>
    <hr>
</asp:Content>

