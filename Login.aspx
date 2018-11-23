<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link type="text/css" rel="stylesheet" href="../Styles/login.css" />
    <title>Login</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content1" Runat="Server">
    <div>
        <div id="loginPanel">
            <asp:Login ID="login" runat="server" OnAuthenticate="login_Authenticate">
            </asp:Login>
        </div>
    </div>
</asp:Content>