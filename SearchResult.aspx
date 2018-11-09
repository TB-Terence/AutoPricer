<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SearchResult.aspx.cs" Inherits="SearchResult" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Table ID="results" runat="server">
            <asp:TableRow ID="result1">
                <asp:TableCell>
                    <asp:Table ID="carView1" runat="server" Width="300" Height="200">
                        <asp:TableRow>
                            <asp:TableCell>
                                <asp:Image runat="server" ID="carImage" Width="300" Height="200"/>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                <div id="carDescription">
                                    Car description #placeholder# #placeholder# #placeholder# #placeholder#
                                </div>
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    
                </asp:TableCell>
                <asp:TableCell Width="300">
                    <asp:Table ID="carDetails" runat="server">
                        <asp:TableRow>
                            <asp:TableCell>
                                <div id="carName">
                                    Car Name
                                </div>
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                Model Name:
                            </asp:TableCell>
                            <asp:TableCell ID="modelName">
                                ?
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                Make:
                            </asp:TableCell>
                            <asp:TableCell ID="make">
                                ?
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                Mileage:
                            </asp:TableCell>
                            <asp:TableCell ID="mileage">
                                ?km
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                Age:
                            </asp:TableCell>
                            <asp:TableCell ID="age">
                                ?
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                Engine:
                            </asp:TableCell>
                            <asp:TableCell ID="engine">
                                ?
                            </asp:TableCell>
                        </asp:TableRow>
                        <asp:TableRow>
                            <asp:TableCell>
                                Condition:
                            </asp:TableCell>
                            <asp:TableCell ID="condition">
                                ?
                            </asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                </asp:TableCell>
                <asp:TableCell>
                    <div>
                        Price:
                    </div>
                    <div id="price">
                        $?
                    </div>
                    <asp:Button runat="server" Text="View Details" ID="btnViewDetails"/>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
    </form>
</body>
</html>
