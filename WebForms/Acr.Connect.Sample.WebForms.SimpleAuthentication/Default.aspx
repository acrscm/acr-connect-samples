<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Acr.Connect.Sample.WebForms.SimpleAuthentication.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:button runat="server" ID="LogoffButton" Text="Log off" OnClick="LogoffButton_OnClick"></asp:button>
        <asp:button runat="server" ID="LoginButton" Text="ACR ID" ToolTip="Log in using your ACR ID account." OnClick="LoginButton_OnClick"></asp:button>
        <asp:Label runat="server" ID="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
