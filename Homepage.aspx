<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>HomePage</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <div >
        <select id="Select1">
            <option></option>
            <option>Profile</option>
            <option>List</option>
            <option>Filter</option>
        </select>
        <select id="Select2">
            <option></option>
            <option>About</option>
            <option>Contact</option>
        </select>
    </div>
    <nav style="margin: 8px 8px 8px 8px">
        <img src="" alt="" />
    </nav>
</asp:Content>
