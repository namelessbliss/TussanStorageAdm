<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html lang="es" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="css/bootstrap.min.css" />
    <link rel="stylesheet" type="text/css" href="css/fontawesome-all.min.css" />
    <link href="https://fonts.googleapis.com/css?family=Roboto:300,400,700,900" rel="stylesheet" />
    <link rel="stylesheet" type="text/css" href="css/estilos.css" />

    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
    <script src="js/bootstrap.min.js"></script>

    <title>Tussan</title>
</head>
<body>



    <!--navbar-->
    <div class="container-fluid navbar-dark bg-primary fixed-top">
        <nav class="navbar navbar-expand-lg container">
            <a class="navbar-brand" href="#">Almacen Tussan</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarNav">
                <ul class="navbar-nav ml-auto">
                    <li class="nav-item active">
                        <a class="nav-link" href="#login">Login</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#servicio">Servicios</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#historia">Nuestra Historia</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#contacto">Contacto</a>
                    </li>
                </ul>
            </div>
        </nav>
    </div>
    <!--navbar-->


    <!--LOGIN-->
    <div id="login" class="fondo py-sm-5">
        <div class="container-fluid pt-5 sombra">
            <div class="container py-sm-5">
                <div class="row pt-3 py-sm-2 py-md-2 py-xl-2">

                    <div class="col-xl-8 col-md-6 col-sm-12 py-0">
                        <h2 class="pb-2 text-white">Bienvenido al Sistema Almacen Tussan</h2>
                        <p class="text-white">
                            Ultimas noticias sobre las reglas del negocio:
                            - Esta es una presentacion del sistema actual para
                            control y registro de almacen de nuestra empresa
                       
                        </p>
                    </div>

                    <div class="col-xl-4 col-md-6 col-sm-12">
                        <!--LOGIN-->
                        <div class="card text-center">
                            <div class="card-block p-0 p-sm-4 p-md-4 p-xl-4">
                                <div class="py-0 py-sm-3 py-md-3 py-xl-3">
                                    <span class="display-4 display-sm-4 display-md-4 display-xl-4 align-items-middle">Inicio Sesion</span>
                                </div>
                                <form id="form1" action="#" class="row justify-content-center" runat="server">
                                    <div>
                                        <div class="form-group col-12">
                                            <asp:TextBox runat="server" type="text" placeholder="Usuario" class="form-control" ID="txtUsuario" />
                                        </div>
                                        <div class="form-group col-12">
                                            <asp:TextBox runat="server" type="password" placeholder="Contraseña" class="form-control" ID="txtContraseña" />
                                        </div>
                                        <div class="col-12 py-2">
                                            <div class="row justify-content-center">
                                                <asp:Button runat="server" Text="Ingresar" class="btn bg-primary text-white col-6" ID="btnLogin" OnClick="btnLogin_Click" />
                                            </div>
                                        </div>
                                    </div>
                                </form>
                            </div>
                            <a href="#" class="card-footer btn bg-primary text-white">Olvide mi contraseña</a>
                        </div>
                        <!--LOGIN-->
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--LOGIN-->


    <!--SERVICIOS-->
    <div id="servicio" class="container-fluid bg-morado">
        <div class="container py-5">
            <div class="row">
                <!--SERVICIO N1-->
                <div class="col-xl-4 col-md-6 col-xm-12 py-1">
                    <div class="card text-center">
                        <div class="card-block">
                            <div class="py-3">
                                <span class="h1">$</span><span class="display-1 align-items-middle">10</span>
                            </div>
                            <p class="h1">
                                Por
                               
                                <math style="font-family: Verdana" xmlns="http://www.w3.org/1998/Math/MathML"><msup><mi>m</mi><mn>3</mn></msup></math>
                                al día
                           
                            </p>
                            <h4 class="card-title py-2"><b>Almacenamiento</b></h4>
                            <p class="card-text mx-2">Almacenamiento de paquetes en nuestro almacen bajo estrictos parametros de seguridad.</p>
                        </div>
                        <a href="#" class="card-footer btn bg-primary text-white">Contratar</a>
                    </div>
                </div>
                <!--SERVICIO N1-->
                <!--SERVICIO N2-->
                <div class="col-xl-4 col-md-6 col-xm-12 py-1">
                    <div class="card text-center">
                        <div class="card-block">
                            <div class="py-3">
                                <span class="h1">$</span><span class="display-1 align-items-middle">5.50</span>
                            </div>
                            <p class="h1">Por  Kilogramo</p>
                            <h4 class="card-title py-2"><b>Recepcion de paquetes</b></h4>
                            <p class="card-text mx-2">Trasporte de paquetes hacia el almacen, si no cuentas con un vehiculo, nos encargamos del trasporte inicial.</p>
                        </div>
                        <a href="#" class="card-footer btn bg-primary text-white">Contratar</a>
                    </div>
                </div>
                <!--SERVICIO N2-->
                <!--SERVICIO N3-->
                <div class="col-xl-4 col-md-6 col-xm-12 py-1">
                    <div class="card text-center">
                        <div class="card-block">
                            <div class="py-3">
                                <span class="h1">$</span><span class="display-1 align-items-middle">8.50</span>
                            </div>
                            <p class="h1">Por  Kilogramo</p>
                            <h4 class="card-title py-2"><b>Trasnporte</b></h4>
                            <p class="card-text">Entrega de paquetes al punto solicitado,si no cuentas con un vehiculo, nos encargamos de transportar los paquetes que tengas en almacen.</p>
                        </div>
                        <a href="#contacto" class="card-footer btn bg-primary text-white">Contratar</a>
                    </div>
                </div>
                <!--SERVICIO N3-->
            </div>
        </div>
    </div>
    <!--SERVICIOS-->


    <!--HISTORIA-->
    <div id="historia" class="container-fluid bg-fondo-crema">
        <div class="container py-5">
            <div class="row align-items-center text-right py-5">
                <div class="col-12 col-sm-6 col-md-6 col-sxl-6">
                    <p class="display-4 pb-5">TUSSAN S.A.C.</p>
                    <p><b>Somos una empresa proveedora de servicio de logística a clientes y a empresas, tanto privadas como públicas.</b></p>
                    <h2 class="pb-5">Visión:</h2>
                    <p><b>"Nuestra visión ser la empresa peruana de logística de mayor preferencia y confiabilidad para las empresas del mercado nacional”.</b></p>
                    <h2 class="pb-5">Misión:</h2>
                    <p><b>"Somos una organización que brinda soluciones empresariales logísticos de almacenaje y transporte de paquetes con profesionalismo, seguridad y puntualidad a los lugares de destino definidos por nuestros clientes.”</b></p>
                </div>
                <div class="col-12 col-sm-6 col-md-6 col-sxl-6">
                    <img src="img/Documentos.jpg" class="img-fluid" width="500px">
                </div>
            </div>
        </div>
    </div>

    <div class="container-fluid bg-fondo-crema mb-2">
        <div class="row text-center mx-5">
            <div class="col-12">
                <p class="display-4 ">Historia</p>
                <p><b>TUSSAN nace hace 3 años cuando su fundador el Sr. Norvic decide crear una empresa dedicada a la logística de documentos sumamente confidenciales de estudios contables y entidades jurídicas poco a poco fue incrementando su clientela y hoy es un referente en el rubro de logística para el sector jurídico. </b></p>
            </div>
        </div>
    </div>
    <!--HISTORIA-->


    <!--CONTACTO-->
    <div id="contacto" class="container py-5">
        <div class="text-center">
            <h2>Contáctanos</h2>
            <h4 class="py-4">Para ponerse en contacto con nuestra empresa, por favor llene los campos del siguiente formulario, nos pondremos en contacto con usted tan pronto nos sea posible.</h4>
        </div>
        <form action="#" class="row justify-content-center">
            <div class="form-group col-md-3">
                <input type="text" placeholder="Nombre" class="form-control" />
            </div>
            <div class="form-group col-md-3">
                <input type="email" placeholder="E-mail" class="form-control" />
            </div>
            <div class="form-group col-md-3">
                <input type="text" placeholder="Teléfono" class="form-control" />
            </div>
            <div class="col-md-12 py-4">
                <div class="row justify-content-center">
                    <button class="btn btn-primary col-md-2">Enviar</button>
                </div>
            </div>
        </form>
    </div>
    <!--CONTACTO-->

    <footer class="container-fluid bg-dark text-center text-white py-5">
        <p>Sitio web desarrollado por TunquiSolutions | Copyright 2019</p>
    </footer>
</body>
</html>
