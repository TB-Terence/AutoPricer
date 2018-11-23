<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SearchResult.aspx.cs" Inherits="SearchResult" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView id="carsGrid" runat="server" AllowPaging="True" AllowSorting="True" OnPageIndexChanging="carsGrid_PageIndexChanging" OnSorting="carsGrid_Sorting" AutoGenerateColumns="False" OnSelectedIndexChanged="carsGrid_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="Model" HeaderText="Model" SortExpression="Model" />
                <asp:BoundField DataField="Make" HeaderText="Make" SortExpression="Make" />
                <asp:BoundField DataField="Mileage" HeaderText="Mileage" SortExpression="Mileage" />
                <asp:BoundField DataField="Engine" HeaderText="Engine" SortExpression="Engine" />
                <asp:BoundField DataField="Condition" HeaderText="Condition" SortExpression="Condition" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
