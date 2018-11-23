<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Homepage.aspx.cs" Inherits="Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HomePage</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <header>
        <label>AutoPrice</label> <nav style="text-align: right;"> <input id="Btn_Login" type="button" value="Login"/><input id="Btn_Register" type="button" value="Register" /></nav>
    </header>
    <nav style="text-align:center;" >
        <input id="Txt_Search" type="text" />
        <input id="Btn_Search" type="button" value="search" />
    </nav>
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

    <footer><label>Copyright</label></footer>
        </div>
    </form>
</body>
</html>
