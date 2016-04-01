<%@ Page Title="Connect to ACR" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Connect.aspx.cs" Inherits="Acr.Connect.Samples.WebForms.RefreshToken.Connect" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    
    <table>
        <tr>
            <td>Authentication Service URL:</td>
            <td><asp:TextBox ID="AuthenticationServiceUrl" Width="500" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Client ID:</td>
            <td><asp:TextBox ID="ClientId" Width="500" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Client Secret:</td>
            <td><asp:TextBox ID="ClientSecret" Width="500" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Redirect URL:</td>
            <td><asp:TextBox ID="RedirectUrl" Width="500" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Scope:</td>
            <td><asp:TextBox ID="Scope" Width="500" runat="server"></asp:TextBox></td>
        </tr>
    </table>
    <br>

    <h3>Click here to verify your ACR account.</h3>
    <asp:Button Text="Login to ACR" runat="server" OnClick="OnClick"/>
    <br>
    <asp:Label runat="server" ForeColor="Red">Refresh Token:</asp:Label>
    <br>
    <asp:Label ID="RefreshToken" runat="server"></asp:Label>
    <br>
    <asp:Button ID="GetAccessTokenButton" Text="Request Access Token" runat="server" OnClick="GetAccessTokenButton_OnClick" Enabled="False"/>
    <br>
    <asp:Label runat="server" ForeColor="Red">Access Token:</asp:Label>
    <br>
    <asp:Label ID="AccessToken" runat="server"></asp:Label>
    <br>
</asp:Content>
