<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Register</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <div style="text-align:center; width:300px; background-color:#DFDFDF">
            <asp:Table runat="server">
                <asp:TableRow>
                    <asp:TableCell>
                        Username:
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="tbUsername" runat="server"/>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        Password:
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="tbPassword" runat="server"/><br />
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        Email:
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="tbEmail" runat="server"/>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        Address:
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="tbAddress" runat="server"/>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        Phone Number:
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="tbPhone" runat="server" type="number"/>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>

            <asp:Button ID="btnBack" runat="server" Text="Back" onclick="btnBack_Click"/>
            <asp:Button ID="btnRegister" runat="server" Text="Register" onclick="btnRegister_Click"/><br />
            <asp:Label ID="labelWarning" runat="server" Text=""/>
        </div>
</asp:Content>
