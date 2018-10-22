<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="misOffertas.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/bootstrap-theme.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>

</head>
<body>
    <div class="container">
        <div class="col-lg-2"></div>
        <div class="col-lg-2">
        <div class="jumbotron" style="margin-top:150px">
            <h3>Mis Ofertas</h3>
         <form id="form1" runat="server" >
            <div class="form-group has-success" >
                <asp:TextBox ID="txtUsuario" runat="server" class="form-control" placeholder="CORREO"></asp:TextBox>
            </div>
            <div class="form-group has-success" >
                <asp:TextBox ID="txtPassword" runat="server" class="form-control" placeholder="CONTRASEÑA"></asp:TextBox>
            </div>
             <div class="checkbox">
               
                    <asp:CheckBox ID="chkRecordarPass" runat="server" />
                <asp:Label ID="Label3" runat="server" Text="Recordarme"> </asp:Label>
            </div>
            <div class="alert-info">
                <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
            </div>
        <asp:Button ID="Button1" runat="server" Text="INGRESAR" OnClick="Button1_Click"  CssClass="btn btn-primary form-control"/>
    </form>
        </div>
    </div>
    <div class="col-lg-4">

    </div>
   </div>
    
</body>
</html>
