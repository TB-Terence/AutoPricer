<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Listing_Result.aspx.cs" Inherits="Listing_Result" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource">

            </asp:ListView>
            <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Car]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
