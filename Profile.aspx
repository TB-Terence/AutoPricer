<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Profile.aspx.cs" Inherits="Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center; width:300px; background-color:#DFDFDF">
            <asp:Table runat="server">
                <asp:TableRow>
                    <asp:TableCell>
                        Credit Card Number:
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="tbUsername" runat="server" A/>
                    </asp:TableCell></asp:TableRow><asp:TableRow>
                    <asp:TableCell>
                        Expiration Date:
                    </asp:TableCell><asp:TableCell>
                        <asp:TextBox ID="tbPassword" runat="server"/><br />
                    </asp:TableCell></asp:TableRow><asp:TableRow>
                    <asp:TableCell>
                        CVD:
                    </asp:TableCell><asp:TableCell>
                        <asp:TextBox ID="tbEmail" runat="server"/>
                    </asp:TableCell></asp:TableRow><asp:TableRow>
                    <asp:TableCell>
                        <asp:Button ID="btnBack" runat="server" Text="Back" onclick="btnBack_Click"/>
                    </asp:TableCell><asp:TableCell>
                        <asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click"/>
                    </asp:TableCell></asp:TableRow>

            </asp:Table>
            </form>

</body>

</html>