<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center; width:500px; background-color:#DFDFDF">
            Enter the criterias, enter the other ones blink
            <asp:Table runat="server">
                <asp:TableRow>
                    <asp:TableCell>
                        Model Name:
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="tbModel" runat="server"/>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        Make:
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="tbMake" runat="server"/>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        Milage:
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="tbMilageMin" runat="server" type="number"/> to  <asp:TextBox ID="tbMilageMax" runat="server" type="number"/>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        Age:
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="tbAgeMin" runat="server" type="number"/> to  <asp:TextBox ID="tbAgeMax" runat="server" type="number"/>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        Engine:
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="tbEngine" runat="server"/>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        Condition:
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="tbCondition" runat="server"/>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
            <asp:Button ID="btnSearch" runat="server" Text="Search" onclick="btnSearch_Click"/><br/>
            <asp:Label ID="labelWarning" runat="server" Text=""/>
        </div>
    </form>
</body>
</html>
