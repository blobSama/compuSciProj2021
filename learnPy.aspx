<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="learnPy.aspx.cs" Inherits="compuSciProj2021.learnPy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Coding Tutorials</title>
    <link rel="stylesheet" type="text/css" href="css/styleSheet.css"/>
    <script src="script/projScript.js"></script>
</head>
<body>
    <div id="header">
        <ul>
            <li><a class="bttn1" href="Homepage.aspx">Home Page</a></li>
            <li><a class="bttn1" href="signIn.aspx">Sign In</a></li>
            <li><a class="bttn1" href="Register.aspx">Register</a></li>
            <li><a class="bttn1" href="usersData.aspx">Users Data</a></li>
            <li><a class="bttn1" href="about.aspx">About Us</a></li>
            <li><asp:HyperLink CssClass="bttn1" ID="infoUpdate" href="updateInfo.aspx" runat="server">Update User Info</asp:HyperLink></li>
            <li><asp:HyperLink CssClass="bttn1" ID="learnPython" href="learnPy.aspx" runat="server">Courses</asp:HyperLink></li>
            <li style="float:right"><asp:Label ID="hello" CssClass="greet" runat="server" Text=""></asp:Label></li>
        </ul>
        <br/>
    </div>
    <br />
    <div id="title">
        <p>SmartWatch Comparison</p>
    </div>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
    <footer id="foot1">
        <p>contact us - ariel.berant@gmail.com</p>
    </footer>
</body>
</html>
