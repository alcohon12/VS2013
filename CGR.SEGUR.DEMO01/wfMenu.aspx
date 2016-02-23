<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="wfMenu.aspx.vb" Inherits="CGR.SEGUR.DEMO01.wfMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="The description of my page" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center">
          <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Underline="True" Text="SISTEMA DE DEMO" Font-Names="Arial Black" style="text-align: center"></asp:Label>
     </div>
        <div style="font-family:Arial;text-align:right;">
         <asp:HyperLink ID="menuSalir_item1" runat="server" style="font-size: small;color:red; text-decoration: underline;" >  Acceso Sistemas CGR</asp:HyperLink>
        </div>
    </form>
</body>
</html>
