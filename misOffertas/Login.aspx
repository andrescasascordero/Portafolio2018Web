<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="misOffertas.login" %>

<!DOCTYPE html>
<html lang="en">

  <head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>MisOfertas - Login</title>

    <!-- Bootstrap core CSS-->
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom fonts for this template-->
    <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">

    <!-- Custom styles for this template-->
    <link href="css/sb-admin.css" rel="stylesheet">

  </head>

  <body class="bg-dark">

    <div class="container">
      <div class="card card-login mx-auto mt-5">
        <div class="card-header">Login</div>
        <div class="card-body">
          <form id="form1" runat="server" >
            <div class="form-group">

                <asp:TextBox ID="txtUsuario" runat="server" class="form-control" placeholder="CORREO ELECTRONICO"></asp:TextBox>                <label for="inputEmail">Email address</label>
             
            </div>
            <div class="form-group">
             
                <asp:TextBox ID="txtPassword" runat="server" class="form-control" placeholder="CONTRASEÑA"></asp:TextBox>
              
            </div>
            <div class="form-group">
              <div class="checkbox">
                <label>
                  <asp:CheckBox ID="chkRecordarPass" runat="server" />
                  Remember Password
                </label>
              </div>
            </div>
             <asp:Button ID="Button1" runat="server" Text="INGRESE ACÁ" OnClick="Button1_Click"  CssClass="btn btn-primary form-control"/>
          <div>
              <asp:Label ID="lblMensaje" runat="server" Text=""> </asp:Label>

              
              </div>
          </form>
          <div class="text-center">
            <a class="d-block small mt-3" href="register.html">Register an Account</a>
            <a class="d-block small" href="forgot-password.html">Forgot Password?</a>
          </div>
        </div>
      </div>
    </div>

    <!-- Bootstrap core JavaScript-->
    <script src="vendor/jquery/jquery.min.js"></script>
    <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

    <!-- Core plugin JavaScript-->
    <script src="vendor/jquery-easing/jquery.easing.min.js"></script>

  </body>

</html>