<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" MasterPageFile="~/MasterPage.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <title>Home</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content1" Runat="Server">
    <div id="banner">
        <div id="searchBar">
            <asp:TextBox runat="server"></asp:TextBox>
            <asp:Button runat="server" Text="Search" OnClick="Search"/>
        </div>
    </div>
</asp:Content>