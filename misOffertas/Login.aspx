<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="misOffertas.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <!-- <link href="Content/bootstrap.min.css" rel="stylesheet" /> -->
    <title></title>
</head>
    
   <!-- <script src="Scripts/bootstrap.min.js"></script>
<script src="Scripts/jquery-3.0.0.min.js"></script> -->
<body>
    <form id="form1" runat="server">
     <div class="container" >
       <!-- <div class="col-md-4"> -->
        <asp:Label ID="Label1" runat="server" Text="USUARIO"></asp:Label>
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
       <!-- </div> --> 
       <br/>
       <!-- <div class="col-md-4" -->
        <asp:Label ID="Label2" runat="server" Text="CONTRASEÑA"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
       <!-- </div> --> 
         <br/>
         <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
        <br/>
        <asp:Button ID="Button1" runat="server" Text="INGRESAR" OnClick="Button1_Click" cssclass="btn btn-outline-success"/>

   </div>
 </form>
</body>
</html>
