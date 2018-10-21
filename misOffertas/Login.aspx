<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="misOffertas.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:Label ID="Label1" runat="server" Text="USUARIO"></asp:Label>
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        <br/>
        <asp:Label ID="Label2" runat="server" Text="CONTRASEÑA"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <br/>
         <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
        <br/>
        <asp:Button ID="Button1" runat="server" Text="INGRESAR" OnClick="Button1_Click" />

    </div>
    </form>
</body>
</html>
