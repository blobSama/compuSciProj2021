
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jobSignUp.aspx.cs" Inherits="compuSciProj2021.jobs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>All Tests</title>
	<link rel="stylesheet" type="text/css" href="css/styleSheet.css"/>
    <script src="script/projScript.js"></script>
</head>
<body>
    <div id="header">
        <ul class="header">
            <li><a class="bttn1" href="Homepage.aspx">Home Page</a></li>
            <li><a class="bttn1" href="signIn.aspx">Sign In</a></li>
            <li><a class="bttn1" href="Register.aspx">Register</a></li>
            <li><asp:HyperLink CssClass="bttn1" ID="userData" href="usersData.aspx" runat="server">Users Data</asp:HyperLink></li>
            <li><a class="bttn1" href="about.aspx">About Us</a></li>
            <li><asp:HyperLink CssClass="bttn1" ID="infoUpdate" href="updateInfo.aspx" runat="server">Update User Info</asp:HyperLink></li>
            <li><asp:HyperLink CssClass="bttn1" ID="learnPython" href="learnPy.aspx" runat="server">Courses</asp:HyperLink></li>
            <li><asp:HyperLink CssClass="bttn1" ID="tests" href="showTests.aspx" runat="server">Available Tests</asp:HyperLink></li>
            <li><asp:HyperLink CssClass="bttn1" ID="showDonetests" href="allTests.aspx" runat="server">Completed Tests</asp:HyperLink></li>
            <li style="float:right"><asp:Label ID="hello" CssClass="greet" runat="server" Text=""></asp:Label></li>
        </ul>
        <br/>
    </div>
    <br />
    <div id="title">
        <p>Learn python!</p>
    </div>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="phoneNum" runat="server" Text="Phone Number: "></asp:Label>
            <asp:TextBox ID="usrPhone" runat="server"></asp:TextBox><br />
            <asp:Label ID="addrs" runat="server" Text="Street Name and Number: "></asp:Label>
            <asp:TextBox ID="usrAddrs" runat="server"></asp:TextBox><br />
            <asp:Label ID="city" runat="server" Text="City: "></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList><br />
        </div>
    </form>
</body>
</html>
